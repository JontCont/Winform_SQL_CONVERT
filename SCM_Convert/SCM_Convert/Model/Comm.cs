using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Diagnostics;

namespace SCM_Convert
{
    class Comm
    {
        public string SET_DBComm { get; set; }
        public string GET_DBComm { get; set; }
        public string GET_Rows_Coumt { get; set; }
        public string GET_Run_Timer { get; set; }
        /// <summary>
        /// 連線至要取得的DB
        /// </summary>
        /// <returns></returns>
        public SqlConnection Set_GetDBConnection()
        {
            string queryString = "waitfor delay '00:00:05'";
            using (SqlConnection Connect = new SqlConnection(GET_DBComm))
            {
                Connect.Open();
                _ = new SqlCommand(queryString, Connect)
                {
                    CommandTimeout = 5
                };
                return Connect;
            }
        }

        /// <summary>
        /// 連線至要被更新的DB
        /// </summary>
        /// <returns></returns>
        public SqlConnection Set_SetDBConnection()
        {
            SqlConnection Connect;
            Connect = new SqlConnection(SET_DBComm);
            Connect.Open();
            return Connect;
        }

        /// <summary>
        /// 連線至要被更新的DB
        /// </summary>
        /// <returns></returns>
        public SqlConnection Comm_TestDBConnection(string sComm)
        {
            SqlConnection Connect;
            Connect = new SqlConnection(sComm);
            Connect.Open();
            return Connect;
        }

        /// <summary>
        /// 傳入一個SQL語法，回傳一個DataTable
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public DataTable Get_DataTable(string pSql)
        {
            DataTable datatable = new DataTable();
            try
            {
                if (pSql.Length > 0)
                {
                    using (SqlConnection con_db = Set_GetDBConnection())
                    {
                        SqlDataAdapter Adapter = new SqlDataAdapter(pSql, con_db);
                        Adapter.Fill(datatable);
                    }
                }
                return datatable;
            }
            catch (Exception)
            {
                //錯誤處理
                throw;
            }
        }

        /// <summary>
        /// 傳入一個SQL語法，刪除一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Del_DBTable(string pSql)
        {
            try
            {
                if (pSql.Length > 0)
                {
                    using (SqlConnection con_db = Set_SetDBConnection())
                    {
                        SqlCommand commd = new SqlCommand(pSql, con_db);
                        commd.ExecuteNonQuery();
                        con_db.Close();
                    }
                }
            }
            catch (Exception)
            {
                //錯誤處理
                throw;
            }
        }

        /// <summary>
        /// 測試連線狀態
        /// </summary>
        /// <param name="comm"></param>
        /// <returns></returns>
        public bool commDB(string comm)
        {
            try
            {
                using (SqlConnection con_db = Comm_TestDBConnection(comm))
                {
                    con_db.Close();
                    return true;
                }
            }
            catch{return false;}
        }

        /// <summary>
        /// 傳入一個SQL語法，INSERT一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Insert_SaveDB(string sTable, string sSql)
        {
            DataTable dTmp = Get_DataTable(sSql);
            if (dTmp.Rows.Count > 0)
            {
                GET_Rows_Coumt = dTmp.Rows.Count.ToString();
                Stopwatch timer = new Stopwatch();
                timer.Start();
                using (SqlBulkCopy con_db = new SqlBulkCopy(Set_SetDBConnection()))
                {
                    con_db.DestinationTableName = sTable;
                    try
                    {
                        con_db.WriteToServer(dTmp);
                        timer.Stop();
                        GET_Run_Timer = timer.ElapsedMilliseconds.ToString();
                    }
                    catch (Exception e) { }
                }
            }
        }

        /// <summary>
        /// 傳入一個SQL語法，INSERT一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Insert_SaveDB(string sTable, DataTable dTmp)
        {
            if (dTmp.Rows.Count > 0)
            {
                GET_Rows_Coumt = dTmp.Rows.Count.ToString();
                using (SqlBulkCopy con_db = new SqlBulkCopy(Set_SetDBConnection()))
                {
                    con_db.DestinationTableName = sTable;
                    try
                    {
                        con_db.WriteToServer(dTmp);
                    }
                    catch (Exception e) { }
                }
            }
        }

        /// <summary>
        /// 傳入一個SQL語法，DELETE一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Delete_PurCode(string sTable,string sStr)
        {
            DataTable dTmp = Get_DataTable(sStr);
            if (dTmp.Rows.Count > 0)
            {
                string sSql  = " DELETE FROM  " + sTable + " WHERE  pur_code=@pur_code";
                foreach (DataRow dr in dTmp.Rows) {
                    using (SqlConnection conn_db = Set_SetDBConnection()) {
                        conn_db.Execute(sSql, new { pur_code = dr[0] });
                    }
                }
            }
        }

    }
}
