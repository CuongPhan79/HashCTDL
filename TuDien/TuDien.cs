using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using SpeechLib;
using System.IO;
namespace TuDien
{
    public partial class TuDien : Form
    {
        public TuDien()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DanhMuc danhMuc = new DanhMuc();
            danhMuc.ReadFromData();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtNhap.Text;
            if (s!="")
            {
                DanhMuc dm = new DanhMuc();
                dm.ReadFromData();
                Nghia.Items.Clear();
                Nghia.Items.Add(dm.writedata(s.ToString()));
            }
            
        }
        string tam = "";

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {
            DSNghia.Items.Clear();
            DanhMuc dm = new DanhMuc();
            dm.ReadFromData();

            tam = txtNhap.Text;
            tam = tam.ToLower();
            if(tam!="")
            {
                string[] tuvung = new string[50];
                dm.HienThiTuLienQuan(tam, ref tuvung);
                int dem = 0;
                foreach(string item in tuvung)
                {
                    if (item != null)
                    {
                        DSNghia.Items.Add(item);
                        dem++;
                    }
                    else
                        break;
                }
                /*if (dem == 0)
                {
                    MessageBox.Show("Khong co tu ban can tim");
                    txtNhap.Text = "";
                }*/
            }
                

        }

        private void DSNghia_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string s = (string)DSNghia.SelectedItem;
            txtNhap.Text = s;
            DanhMuc dm = new DanhMuc();

            dm.ReadFromData();
            Nghia.Items.Clear();
            Nghia.Items.Add(dm.writedata(s.ToString()));
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SpVoice sp = new SpVoice();
            sp.Speak(txtNhap.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::TuDien.Properties.Resources.ee;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::TuDien.Properties.Resources._061181_blue_jelly_icon_people_things_speech;
        }

        private void thêmTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTu themTu = new ThemTu();
            themTu.Show();
        }

        private void xóaTừToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
