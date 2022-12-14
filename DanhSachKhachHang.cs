using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPSQL
{
    public partial class DanhSachKhachHang : Form
    {
        int index;
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FetchData();
            if (dataGridView1.Rows.Count > 1)
            {
                DataGridViewRow gdvRow = dataGridView1.Rows[0];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                txtDate.Text = gdvRow.Cells[2].Value.ToString();
                txtNGDK.Text = gdvRow.Cells[3].Value.ToString();
                index = 0;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1) {
                DataGridViewRow gdvRow = dataGridView1.Rows[e.RowIndex];
                txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                txtname.Text = gdvRow.Cells[1].Value.ToString();
                txtDate.Text = gdvRow.Cells[2].Value.ToString();
                txtNGDK.Text = gdvRow.Cells[3].Value.ToString();
                index=e.RowIndex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(index);
            Database.DeleteKH(txtMSKH.Text);
            //if (index == dataGridView1.Rows.Count - 1)
            //    index--;
            if (dataGridView1.Rows.Count > 0)
            {      
                    DataGridViewRow gdvRow = dataGridView1.Rows[index];
                    txtMSKH.Text = gdvRow.Cells[0].Value.ToString();
                    txtname.Text = gdvRow.Cells[1].Value.ToString();
                    txtDate.Text = gdvRow.Cells[2].Value.ToString();
                    txtNGDK.Text = gdvRow.Cells[3].Value.ToString();
            }
        }
        public void FetchData()
        {
            List<KhachHang> ds = Database.FetchingKhachHangData();
            for(int i = 0; i < ds.Count;i++) {
                dataGridView1.Rows.Add(ds[i].MSKH, ds[i].Name, ds[i].BirthDate.ToString("dd/MM/yyyy"), ds[i].RegisterDate.ToString("dd/MM/yyyy"));
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Hide();
            new Insert().ShowDialog();
        }
    }

}
