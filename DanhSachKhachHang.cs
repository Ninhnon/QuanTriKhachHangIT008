using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WPSQL
{
    public partial class DanhSachKhachHang : Form
    {
        int index;
        public DanhSachKhachHang()
        {
            InitializeComponent();
            NameError.Text = String.Empty;
            DateError.Text = String.Empty;
            NGDKError.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchData();
            if (dataGridView1.Rows.Count > 1)
            {
                DataGridViewRow gdvRow = dataGridView1.Rows[0];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                tp_BirthDay.Value = DateTime.Parse(gdvRow.Cells[2].Value.ToString());
                tp_RegisterDay.Value = DateTime.Parse(gdvRow.Cells[3].Value.ToString());
                index = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dataGridView1.Rows.Count - 1 && dataGridView1.Rows.Count > 1)
            {
                DataGridViewRow gdvRow = dataGridView1.Rows[e.RowIndex];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                tp_BirthDay.Value = DateTime.Parse(gdvRow.Cells[2].Value.ToString());
                tp_RegisterDay.Value = DateTime.Parse(gdvRow.Cells[3].Value.ToString());
                index = e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                dataGridView1.Rows.RemoveAt(index);
                Database.DeleteKH(txtMSKH.Text);
            }
            if (index == dataGridView1.Rows.Count - 1)
               index--;
            if (dataGridView1.Rows.Count > 1)
            {
                DataGridViewRow gdvRow = dataGridView1.Rows[index];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                tp_BirthDay.Value = DateTime.Parse(gdvRow.Cells[2].Value.ToString());
                tp_RegisterDay.Value = DateTime.Parse(gdvRow.Cells[3].Value.ToString());
            }
            else if (dataGridView1.Rows.Count == 1)
            {
                txtMSKH.Text = String.Empty;
                txtname.Text = String.Empty;
            }
        }
        public void FetchData()
        {
            List<KhachHang> ds = Database.FetchingKhachHangData();
            for (int i = 0; i < ds.Count; i++)
            {
                dataGridView1.Rows.Add(ds[i].MSKH, ds[i].Name, ds[i].BirthDate.ToShortDateString(), ds[i].RegisterDate.ToShortDateString());
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Hide();
            new Insert().ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            NameError.Text = String.Empty;
            DateError.Text = String.Empty;
            NGDKError.Text = String.Empty;
            bool isValid = true;

            if (string.IsNullOrEmpty(txtname.Text))
            {
                NameError.Text = "Chưa nhập Tên";
                isValid = false;
            }
            if (string.IsNullOrEmpty(tp_BirthDay.Text))
            {
                DateError.Text = "Chưa chọn ngày sinh";
                isValid = false;
            }
            if (string.IsNullOrEmpty(tp_RegisterDay.Text))
            {
                NGDKError.Text = "Chưa chọn NGDK";
                isValid = false;
            }
            if (!isValid) return;

            if (tp_BirthDay.Value > tp_RegisterDay.Value)
            {
                DateError.Text = "Ngày sinh phải nhỏ hơn ngày đăng ký";
                NGDKError.Text = "Ngày đăng ký phải lớn hơn ngày sinh";
                isValid = false;
            }
            if (!isValid) return;
            KhachHang KH = new KhachHang()
            {
                MSKH = txtMSKH.Text,
                Name = txtname.Text,
                BirthDate = tp_BirthDay.Value,
                RegisterDate = tp_RegisterDay.Value,
            };
            Database.UpdateKH(KH);
            dataGridView1.Rows.Clear();
            FetchData();
            if (dataGridView1.Rows.Count > 1)
            {
                DataGridViewRow gdvRow = dataGridView1.Rows[0];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                tp_BirthDay.Value = DateTime.Parse(gdvRow.Cells[2].Value.ToString());
                tp_RegisterDay.Value = DateTime.Parse(gdvRow.Cells[3].Value.ToString());
                index = 0;
            }
        }
    }

}
