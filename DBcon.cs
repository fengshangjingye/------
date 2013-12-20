using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DBCON
{
    public class Dbcon
    {
        string SQLConStr = "server=.;AttachDbFilename=|DataDirectory|\\yaowu.mdf;database=yaowu;integrated security=yes";
        string SQLConStr2 = "server=.;database=yaowu;integrated security=yes";
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private DataSet ds = new DataSet();
        private SqlDataAdapter sda = null;
        private SqlCommand scom = null;
        private SqlDataReader sdr = null;
        //讀取藥物信息
        public DataSet readY()
        {
            con = new SqlConnection(SQLConStr);
            //con.ConnectionString = SQLConStr;
            string SQL = "select * from yaoping";
            sda = new SqlDataAdapter(SQL, con);
            sda.Fill(ds, "yaoping");
            return ds;
        }
        //藥品添加
        public int addY(string Yname,string Ydate,string Ybaozhi,string Yjiage)
        {
            con = new SqlConnection(SQLConStr);
            int count;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string SQL = "INSERT INTO yaoping VALUES ('"+Yname+"','"+Ydate+"','"+Ybaozhi+"','"+Yjiage+"')";
            cmd = new SqlCommand();
            cmd.CommandText = SQL;
            cmd.Connection = con;
            count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        //藥品刪除
        public int delY(string Yname)
        {
            con = new SqlConnection(SQLConStr);
            int count;
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string SQL = "DELETE FROM yaoping WHERE 藥品名稱 = '"+Yname+"'";
            cmd = new SqlCommand();
            cmd.CommandText = SQL;
            cmd.Connection = con;
            count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        //訂單刪除
        public int delD(string Yname,string suliang,string Date)
        {
            con = new SqlConnection(SQLConStr);
            int count;
            string SQL = "DELETE FROM dingdan WHERE 藥品 = '" + Yname + "'AND 日期 = '" + Date + "' AND 數量 = '"+ suliang +"'";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = SQL;
            cmd.Connection = con;
            count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }
        //訂單添加
        public int addD(string Yname, string Ysuliang, string Yriqi)
        {
            con = new SqlConnection(SQLConStr);
            int count;
            string SQL = "INSERT INTO dingdan VALUES('" + Yname + "','" + Ysuliang + "','" + Yriqi + "')";
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            cmd = new SqlCommand();
            cmd.CommandText = SQL;
            cmd.Connection = con;
            count = cmd.ExecuteNonQuery();
            con.Close();
            return count;
        }

        //讀取訂單信息
        public DataSet readDD()
        {
            con = new SqlConnection(SQLConStr);
            //con.ConnectionString = SQLConStr;
            string SQL = "select * from dingdan";
            sda = new SqlDataAdapter(SQL, con);
            sda.Fill(ds, "dingdan");
            return ds;
        }
        //讀取訂單信息for添加頁面
        public DataTable readDD4add()
        {
            DataTable dt = new DataTable();
            con = new SqlConnection(SQLConStr);
            //con.ConnectionString = SQLConStr;
            string SQL = "select * from yaoping";
            sda = new SqlDataAdapter(SQL, con);
            sda.Fill(dt);
            return dt;
        }
        //關閉
        public void close()
        {
            if(con != null)
            {
            con.Close();
            }
        }
    }
}
