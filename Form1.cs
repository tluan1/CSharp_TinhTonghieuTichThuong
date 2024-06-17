using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_Tinhtong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinhtong_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 + so2;
            txtketqua.Text = ketqua.ToString();
        }

        private void btnTinhhieu_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 - so2;
            txtketqua.Text = ketqua.ToString();
        }
        private void btnTinhtich_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            ketqua = so1 * so2;
            txtketqua.Text = ketqua.ToString();
        }
        private void btnTinhthuong_Click(object sender, EventArgs e)
        {
            Double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtSo1.Text);
            so2 = Convert.ToDouble(txtSo2.Text);
            if (so2 == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo lỗi", MessageBoxButtons.OKCancel);
            }
            else
            {
            ketqua = so1 / so2;
                txtketqua.Text = ketqua.ToString();
            }
        }
    }
}