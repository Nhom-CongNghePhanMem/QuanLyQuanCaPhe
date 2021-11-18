﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyQuanCaPhe
{
    class NThucPham
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public string maTP { set; get; }
        public string tenTP { set; get; }
        public string maNCC { set; get; }
        public string DVT { set; get; }
        public DateTime NSX { set; get; }
        public DateTime HSD { set; get; }

        public NThucPham()
        {
            dc = new DataConnection();
        }
        public DataTable getAllTP()
        {

            string sql = "SELECT * FROM ThucPham";
            SqlConnection con = dc.GetConnection();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertTP(NThucPham tp)
        {
            string sql = "INSERT INTO ThucPham(maThucPham,tenThucPham,donViTinh,NSX,HSD,maNCC) VALUES(@maThucPham, @tenThucPham, @donViTinh, @NSX,  @HSD, @maNCC)";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maThucPham", SqlDbType.Char).Value = tp.maTP;
                cmd.Parameters.Add("@tenThucPham", SqlDbType.NVarChar).Value = tp.tenTP;
                cmd.Parameters.Add("@donViTinh", SqlDbType.NVarChar).Value = tp.DVT;
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = tp.NSX.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = tp.HSD.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = tp.maNCC;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateTP(NThucPham tp)
        {
            string sql = "UPDATE ThucPham SET tenThucPham = @tenThucPham, donViTinh = @donViTinh, NSX = @NSX, HSD = @HSD, maNCC = @maNCC WHERE maThucPham = @maThucPham";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maThucPham", SqlDbType.Char).Value = tp.maTP;
                cmd.Parameters.Add("@tenThucPham", SqlDbType.NVarChar).Value = tp.tenTP;
                cmd.Parameters.Add("@donViTinh", SqlDbType.NVarChar).Value = tp.DVT;
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = tp.NSX.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = tp.HSD.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@maNCC", SqlDbType.Char).Value = tp.maNCC;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteTP(NThucPham tp)
        {
            string sql = "DELETE ThucPham WHERE maThucPham= @maThucPham";
            SqlConnection con = dc.GetConnection();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@maThucPham", SqlDbType.Char).Value = tp.maTP;
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
