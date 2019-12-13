using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TuDien
{
    public partial class ThemTu : Form
    {
        public ThemTu()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThemTu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TuMoi.Text == "" || PhatAm.Text == "" || Nghiaa.Text == "" || TuLoai.SelectedIndex < 0)
                MessageBox.Show("VUI LONG NHAP DAY DU THONG TIN TU MOI");
            else
            {
                DanhMuc dm = new DanhMuc();
                dm.ReadFromData();
                if (dm.themtu(TuMoi.Text, (string) TuLoai.SelectedItem, PhatAm.Text, Nghiaa.Text) == true)
                {
                    //dm.xoadata();
                    dm.WriteToData();
                    MessageBox.Show("BAN DA THEM THANH CONG");
                    
                }
                else MessageBox.Show("TU BAN THEM DA CO TRONG DANH MUC");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Bạn có chắc muốn hủy không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Nghiaa.Text = "";
                TuMoi.Text = "";
                PhatAm.Text = "";
                TuLoai.Text = "";
                TuMoi.Focus();
             
               
            }
        }
    }
}
