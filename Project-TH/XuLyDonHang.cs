using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Project_TH
{
    public partial class XuLyDonHang : Form
    {
        public XuLyDonHang()
        {
            InitializeComponent();
            HienThi();
        }
        void HienThi()
        {
            dataGridView1.DataSource = DON_HANG_BUS.Load_DSDH();
            textBox4.Text = DON_HANG_BUS.DSDH_CHOXULY().ToString();
            comboBox2.DataSource = NHAN_VIEN_BUS.NVGH();
            comboBox2.DisplayMember = "TEN_NHAN_VIEN";
            comboBox2.ValueMember = "MA_NHAN_VIEN";
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void XuLyDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBHDataSet.NHAN_VIEN' table. You can move, or remove it, as needed.
            this.nHAN_VIENTableAdapter.Fill(this.qLBHDataSet.NHAN_VIEN);

        }
    }
}
