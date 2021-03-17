using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SCM_Convert
{
    class Comm
    {
        public string SET_DBComm { get; set; }
        public string GET_DBComm { get; set; }


        public SqlConnection Set_GetDBConnection() {
            SqlConnection Connect;
            Connect = new SqlConnection(GET_DBComm) ;
            Connect.Open();
            return Connect;
        }

        public SqlConnection Set_SetDBConnection()
        {
            SqlConnection Connect;
            Connect = new SqlConnection(SET_DBComm);
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
        /// 傳入一個SQL語法，刪除一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Save_DBTable(string pSql)
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
        /// 傳入一個SQL語法，刪除一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public string Get_DBColumn(DataTable dTmp)
        {
            string sStr = "";
            if (dTmp.Rows.Count > 0)
            {
                foreach (var Col_name in dTmp.Columns)
                {
                    sStr += Col_name + ",";
                }
                sStr = sStr.TrimEnd(',');
            }
            return sStr;
        }

        /// <summary>
        /// 傳入一個SQL語法，INSERT一個DB
        /// </summary>
        /// <param name="pSql">Select語法</param>
        /// <returns></returns>
        public void Insert_SaveDB(string sSql, string sTable , DataTable dTmp)
        {
            if (dTmp.Rows.Count > 0)
            {
                for (int x = 0; x < dTmp.Rows.Count; x++){
                    string sStr = "INSERT INTO "+ sTable + " (" + sSql + ") VALUES(";
                    for(int y = 0;y < dTmp.Columns.Count; y++)
                    {
                        sStr += "'" + dTmp.Rows[x][y] + "',";
                    }
                    sStr = sStr.TrimEnd(','); sStr += ")";
                    Save_DBTable(sStr);
                }
            }
        }

    }
}
