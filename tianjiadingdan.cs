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
    public partial class tianjiadingdan : Form
    {
        private main _main1;
        Dbcon lianjie = new Dbcon();
        DataTable dt = new DataTable();
        public tianjiadingdan(main _main)
        {
            InitializeComponent();
            this._main1 = _main;
            dt = lianjie.readDD4add();
            displaycom.DataSource = dt;
            displaycom.DisplayMember = "藥品名稱";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._main1.suaxing();
            this.Close();
        }

        private void displaycom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tianjiadingdan_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (suliang.Text == "")
            {
                MessageBox.Show("請輸入訂單藥品數量！");
            }
            else if (riqi.Text == "")
            {
                MessageBox.Show("請輸入訂單日期！");
            }
            else if (suliang.Text != "" && riqi.Text != "")
            {
                int count;
                count = lianjie.addD(displaycom.Text.ToString(), suliang.Text.ToString(), riqi.Text.ToString());
                MessageBox.Show("添加成功！");
            }
        }
    }
}
