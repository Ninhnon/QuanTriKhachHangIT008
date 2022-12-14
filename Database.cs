using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WPSQL
{
    public class Database
    {
        static readonly string strCon = @ConfigurationManager.ConnectionStrings["Default"].ToString();
        public static SqlConnection sqlCon = new SqlConnection(strCon);

        static readonly string queryData = @"select * from DanhSachKhachHang";
        static readonly string deleteKH = "delete from DanhSachKhachHang where MSKH='{0}'";
        static readonly string insertKH = "insert into DanhSachKhachHang values( N'{0}',N'{1}',N'{2}',N'{3}')";
        public static void DeleteKH(string MSKH)
        {
            sqlCon.Open();
            var strCmd = string.Format(deleteKH, MSKH);
            SqlCommand cmd = new SqlCommand(strCmd, sqlCon);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            sqlCon.Close();
        }
        public static List<KhachHang> FetchingKhachHangData()
        {
            sqlCon.Open();
            var cmd = new SqlCommand(queryData, sqlCon);

            List<KhachHang> ds = new List<KhachHang>();

            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ds.Add(new KhachHang()
                {
                    MSKH=read.GetString(0),
                    Name=read.GetString(1),
                    BirthDate=read.GetDateTime(2),
                    RegisterDate=read.GetDateTime(3),
                });

            }
            read.Close();
            sqlCon.Close();
            return ds;
        }
        public static void InsertKH(KhachHang khachHang)
        {
            sqlCon.Open();
            var strCmd = $"select * from DanhSachKhachHang where MSKH='{khachHang.MSKH}'";
            var cmd = new SqlCommand(strCmd, sqlCon);
            SqlDataReader reader = cmd.ExecuteReader();

            bool isExisted;
            try
            {
                isExisted = reader.Read();
            }
            catch
            {
                isExisted = false;
            }
            reader.Close();
            if (isExisted)
            {
                MessageBox.Show("Đã có MSKH này!!!");
            }
            else // Nếu chưa, tạo mới loại sản phẩm
            {
                strCmd = string.Format(insertKH, khachHang.MSKH, khachHang.Name, khachHang.BirthDate, khachHang.RegisterDate);
                cmd = new SqlCommand(strCmd, sqlCon);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            sqlCon.Close();
        }
    }
}
