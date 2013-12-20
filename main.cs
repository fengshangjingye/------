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
    public partial class main : Form
    {
        int row;
        Dbcon lianjie;
        public main()
        {
            InitializeComponent();
            
        }
        public void suaxing()
        {
            lianjie = new Dbcon();
            this.displaydata.DataSource = lianjie.readY().Tables["yaoping"];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            chakandingdan dindan = new chakandingdan(this);
            dindan.ShowDialog(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sanchudingdan del = new sanchudingdan(this);
            del.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tianjiadingdan add = new tianjiadingdan(this);
            add.ShowDialog();
        }

        private void main_Load(object sender, EventArgs e)
        {
            suaxing();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count;
            int a = displaydata.CurrentCell.RowIndex;
            string tmp1;
            string tmp2;
            tmp1 = displaydata.Rows[a].Cells[0].Value.ToString();
            tmp2 = tmp1.TrimEnd();
            count = lianjie.delY(tmp2);
            this.suaxing();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tianjiayaoping addyao = new tianjiayaoping(this);
            addyao.ShowDialog();
        }
    }
}
