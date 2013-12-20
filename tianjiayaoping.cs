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
    public partial class tianjiayaoping : Form
    {
        Dbcon lianjie = new Dbcon();
        private main _main1;
        public tianjiayaoping(main _main)
        {
            InitializeComponent();
            this._main1 = _main;
            lianjie = new Dbcon();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this._main1.suaxing();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (Yname.Text == "")
            {
                MessageBox.Show("請輸入藥品名！");
            }
            else if (Ydate.Text == "")
            {
                MessageBox.Show("請輸入生產日期！");
            }
            else if (Yjiage.Text == "")
            {
                MessageBox.Show("請輸入價格！");
            }
            else if (Ybaozhi.Text == "")
            {
                MessageBox.Show("請輸入保質期！");
            }
            else if(Ydate.Text != ""&&Ybaozhi.Text !=""&&Yjiage.Text != ""&&Yname.Text != "")
            {
                int count;
                count = lianjie.addY(Yname.Text.ToString(),Ydate.Text.ToString(),Ybaozhi.Text.ToString(),Yjiage.Text.ToString());
                MessageBox.Show("添加成功！");
            }

        }
    }
}
