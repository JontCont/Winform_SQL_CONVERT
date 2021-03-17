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

namespace SCM_Convert
{
    public partial class Form1 : Form
    {
        Comm comm = new Comm();
        SETDB sETDB = new SETDB();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comm.GET_DBComm = "Data Source=DESKTOP-JCONT\\SQLEXPRESS;Initial Catalog=SUPDB;User ID=sa;Password=root;Pooling=True";
            comm.SET_DBComm = "Data Source=DESKTOP-JCONT\\SQLEXPRESS;Initial Catalog=SUP;User ID=sa;Password=root;Pooling=True";
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
            sETDB.Insert_SUB01_0000();
        }

        private void Btn_Details_Click(object sender, EventArgs e)
        {
            string sSql = " DELETE SUT01_0100 WHERE (pur_code in (SELECT pur_code FROM SUT01_0000 WHERE pur_status ='00')) ";
            comm.Del_DBTable(sSql);
            sETDB.Insert_SUB01_0000();
        }

        private void Btn_ProData_Click(object sender, EventArgs e)
        {
            string sSql = " TRUNCATE TABLE SUB01_0000 ";
            comm.Del_DBTable(sSql);
            sETDB.Insert_SUB01_0000();
        }

    }
}
