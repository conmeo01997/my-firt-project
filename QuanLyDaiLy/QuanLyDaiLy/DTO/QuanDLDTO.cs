using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaiLy.DTO
{
    class QuanDLDTO
    {
             Connection dc;
            SqlDataAdapter da;
            SqlCommand cmd;
            public static string TK = "";
            public QuanDLDTO()
            {
                dc = new Connection();
            }
            public DataTable getQuan()
            {
                string sql = "select * from QuanDL";
                SqlConnection con = dc.GetConnect();
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            public DataTable getQuan1()
            {
                string sql = "select MaQuan from QuanDL";
                SqlConnection con = dc.GetConnect();
                da = new SqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                con.Close();
                return dt;
            }
            public bool InserQuan(QuanDLdata ldl)
            {
                string sql = "Insert into QuanDL (MaQuan, TenQuan) Values(@MaQuan, @TenQuan)";
                SqlConnection con = dc.GetConnect();
                try
                {
                    cmd = new SqlCommand(sql, con);
                    con.Open();
                    cmd.Parameters.Add("@MaQuan", SqlDbType.NChar).Value = ldl.MaQuan;
                    cmd.Parameters.Add("@TenQuan", SqlDbType.NVarChar).Value = ldl.TenQuan;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            public bool UpDateQuan(QuanDLdata ldl)
            {
                try
                {
                    SqlConnection con = dc.GetConnect();
                    con.Open();
                    string sql = "UPDATE QuanDL set TenQuan = @TenQuan where MaQuan = @MaQuan";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@MaQuan", SqlDbType.NChar).Value = ldl.MaQuan;
                    cmd.Parameters.Add("@TenQuan", SqlDbType.NVarChar).Value = ldl.TenQuan;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
            public bool DeleteQuan(QuanDLdata ldl)
            {
                string sql = "DELETE FROM QuanDL Where MaQuan = @MaQuan";
                SqlConnection con = dc.GetConnect();
                try
                {
                    con.Open();
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Add("@MaQuan", SqlDbType.NChar).Value = ldl.MaQuan;
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception e)
                {
                    return false;
                }
                return true;
            }
    }
}
