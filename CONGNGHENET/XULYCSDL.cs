using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Configuration;

namespace CONGNGHENET
{
    class XULYCSDL
    {
        SqlConnection connect;
        SqlDataAdapter da;

        Configuration config;
        public string GetConnectionString(string name)
        {
            return config.ConnectionStrings.ConnectionStrings[name].ConnectionString;
        }
        public XULYCSDL()
        {
            //string chuoiketnoi = "server=GREEND\\SQLEXPRESS; database=QUANLYXEMAY; Integrated Security=false; uid=nv01; pwd=1";
            //string chuoiketnoi = "server=GREEND\\SQLEXPRESS; database=QUANLYXEMAY; Integrated Security=false; uid=admin; pwd=1";
            //string chuoiketnoi = docghiappconfig.GetConnectionString("CONGNGHENET.Properties.Settings.QUANLYXEMAYConnectionString");
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            string chuoiketnoi = GetConnectionString("QUANLYXEMAYConnectionString");
            try
            {
                connect = new SqlConnection(chuoiketnoi);
            }
            catch (SqlException ex)
            {
            }
        }
        public bool testConnection(string connectionstring)
        {
            try
            {
                connect = new SqlConnection(connectionstring);
                connect.Open();
                connect.Close();
                return true;
            }
            catch (SqlException sqle)
            {
                return false;
            }
        }
        public DataTable LayDuLieu(string lenhsql)
        {
            da = new SqlDataAdapter(lenhsql, connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public int THEMXOASUA(string lenhsql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand command = new SqlCommand(lenhsql, connect);
            connect.Close();
            return command.ExecuteNonQuery();
        }
        public int CAPNHAT(string lenhsql, DataTable tablename)
        {
            da = new SqlDataAdapter(lenhsql, connect);
            SqlCommandBuilder comBuilder = new SqlCommandBuilder(da);
            return da.Update(tablename);
        }

        public bool TRIGGER_KTTUOINV(DataTable tablename, string lenhsql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand command = new SqlCommand(lenhsql, connect);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == false)
            {
                connect.Close();
                return false;
            }
            else
            {
                connect.Close();
                return true;
            }
        }
        public bool TimHoaDonTheoMaKH(DataTable tablename, string lenhsql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand command = new SqlCommand(lenhsql, connect);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == false)
            {
                connect.Close();
                return false;
            }
            else
            {
                connect.Close();
                return true;
            }
        }
        public bool XuLyTaiKhoan(string lenhsql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand command = new SqlCommand(lenhsql, connect);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read() == false)
            {
                connect.Close();
                return false;
            }
            else
            {
                connect.Close();
                return true;
            }
        }
        public void DemXeNCC(string lenhsql)
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlCommand command = new SqlCommand(lenhsql, connect);
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}

