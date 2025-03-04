using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class KetQuaDAO
    {
        public List<KetQua> getAll()
        {
            List<KetQua> ds = new List<KetQua>();

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from ketqua", conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                
                {
                    Id = int.Parse(rd["id"].ToString()),
                    MaSV = rd["MaSV"].ToString(),
                    MaMH = rd["MaMH"].ToString(),
                    Diem = float.Parse(rd["diem"].ToString())
                });
                ds.Add(new KetQua()
            }

            return ds;
        }
    }
}