using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WPSQL
{
    public partial class Insert : Form
    {
        SqlConnection connection = new SqlConnection();

        public Insert()
        {
            InitializeComponent();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["Default"].ToString();
            MSKHerror.Text = String.Empty;
            NameError.Text = String.Empty;
            DateError.Text = String.Empty;
            NGDKError.Text = String.Empty;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MSKHerorr.Text = String.Empty;
            NameError.Text = String.Empty;
            DateError.Text = String.Empty;
            NGDKError.Text = String.Empty;
            bool isValid = true;

            if (string.IsNullOrEmpty(txtMSKH.Text))
            {
                MSKHerorr.Text = "Chưa nhập MSSK";
                isValid = false;
            }
            if (string.IsNullOrEmpty(txtname.Text))
            {
                NameError.Text = "Chưa nhập Tên";
                isValid = false;
            }
            if (string.IsNullOrEmpty(NGSinh.Text))
            {
                DateError.Text = "Chưa chọn ngày sinh";
                isValid = false;
            }
            if (string.IsNullOrEmpty(NGDK.Text))
            {
                NGDKError.Text = "Chưa chọn NGDK";
                isValid = false;
            }
            if (!isValid) return;

            if (NGDK.Value <= NGSinh.Value)
            {
                DateError.Text = "Ngày sinh phải nhỏ hơn ngày đăng ký";
                NGDKError.Text = "Ngày đăng ký phải lớn hơn ngày sinh";
                isValid = false;
            }
            if (!isValid) return;
            KhachHang newKH = new KhachHang()
            {
                MSKH = txtMSKH.Text,
                Name = txtname.Text,
                BirthDate = NGSinh.Value,
                RegisterDate = NGDK.Value,
            };
            Database.InsertKH(newKH);
            Hide();
            new DanhSachKhachHang().ShowDialog();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
            new DanhSachKhachHang().ShowDialog();
        }
    }
}
