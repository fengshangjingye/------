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
    public partial class chakandingdan : Form
    {
        Dbcon lianjie = new Dbcon();
        private main _main1;
        public chakandingdan(main _main)
        {
            this._main1 = _main;
            InitializeComponent();
            lianjie = new Dbcon();
            this.dataGridView1.DataSource = lianjie.readDD().Tables["dingdan"];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this._main1.suaxing();
        }

        private void chakandingdan_Load(object sender, EventArgs e)
        {

        }
    }
}
