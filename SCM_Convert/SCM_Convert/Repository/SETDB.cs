using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SCM_Convert.Repository
{
    class SETDB
    {
        Comm comm = new Comm();

        public void Insert_SUB01_0000()
        {
            string sSql = " SELECT * FROM SUB01_0000 ";
            DataTable dTmp = comm.Get_DataTable(sSql);
            //List<SUB01_0000> SUB010A =new List<SUB01_0000>();
            string sCol = comm.Get_DBColumn(dTmp);
            comm.Insert_SaveDB(sCol, "SUB01_0000", dTmp);
        }

        public void Insert_SUB02_0000()
        {
            string sSql = " SELECT * SUB02_0000";
            DataTable dTmp = comm.Get_DataTable(sSql);
            string sCol = comm.Get_DBColumn(dTmp);
            comm.Insert_SaveDB(sCol, "SUB02_0000",dTmp);
        }
    }
}
