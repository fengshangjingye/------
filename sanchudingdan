using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBCON;
namespace 藥物管理系統
{
    public partial class sanchudingdan : Form
    {
        Dbcon lianjie;
        private main _main1;
        public sanchudingdan(main _main)
        {
            this._main1 = _main;
            InitializeComponent();
            suaxing();
        }
        public void suaxing()
        {
            lianjie = new Dbcon();
            this.displayDD.DataSource = lianjie.readDD().Tables["dingdan"];
        }
        private void dingdanesc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dingdandel_Click(object sender, EventArgs e)
        {
            int count;
            int a = displayDD.CurrentCell.RowIndex;
            string tmp1;
            string nameT;
            string DateT;
            string suliangT;
            tmp1 = displayDD.Rows[a].Cells[0].Value.ToString();
            nameT = tmp1.TrimEnd();
            tmp1 = displayDD.Rows[a].Cells[1].Value.ToString();
            suliangT = tmp1.TrimEnd();
            tmp1 = displayDD.Rows[a].Cells[2].Value.ToString();
            DateT = tmp1.TrimEnd();
            count = lianjie.delD(nameT,suliangT,DateT);
            this.suaxing();
        }
    }
}
