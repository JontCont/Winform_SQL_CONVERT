using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCM_Convert.Repository;
using System.Diagnostics;
using LinqToExcel;

namespace SCM_Convert
{
    public partial class Form1 : Form
    {
        Comm comm = new Comm();
        SETDB sETDB = new SETDB();
        InfoResponse response = new InfoResponse();

        string sPath = Application.StartupPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void btn_Comm_Click(object sender, EventArgs e)
        {
            string sPath = Application.StartupPath;
            string sShow = "";
            try
            {
                StreamReader sRead = new StreamReader(sPath + "\\StrLog.MD");
                string sLine = sRead.ReadLine();
                sShow += sLine;
                sRead.Close();
            }
            catch (Exception ex) { MessageBox.Show("無連線訊息"); }
        }

        private void Btn_Sup_Click(object sender, EventArgs e)
        {
            string sSql = " TRUNCATE TABLE SUB02_0000 ";
            comm.Del_DBTable(sSql);
            sETDB.Insert_SUB02_0000();
        }

        private void Btn_SigleHead_Click(object sender, EventArgs e)
        {
            string sSql = " DELETE FROM SUT01_0000 WHERE pur_status='00' ";
            comm.Del_DBTable(sSql);
            sETDB.Insert_SUT01_0000();
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {
            string sSql = " DELETE SUT01_0100 WHERE (pur_code in (SELECT pur_code FROM SUT01_0000 WHERE pur_status ='00')) ";
            comm.Del_DBTable(sSql);
            sETDB.Insert_SUT01_0100();
        }

        private void Btn_ProData_Click(object sender, EventArgs e)
        {
            //設定EXCEL
            var exc = new ExcelQueryFactory(sPath + "\\setting.xlsx");

            var sQuery = from x in exc.Worksheet<Setting>("setting")
                         where x.Table == "SUB01_0000"
                         select x;
            foreach (var name in sQuery)
            {
                if (name.InitialCtr == null || name.changeCtr == null) { response.Message = "設定檔內容有缺無法更新";  break; }
                comm.Del_DBTable(name.InitialCtr);
                sETDB.Insert_SUB01_0000(name.changeCtr);
            }
            //string sSql = " TRUNCATE TABLE SUB01_0000 ";
            //comm.Del_DBTable(sSql);
            //sETDB.Insert_SUB01_0000();
        }

        private void Btn_setting_Click(object sender, EventArgs e)
        {
            //打開設定檔案
            Process.Start(sPath + "\\setting.xlsx");
        }
    }
}
