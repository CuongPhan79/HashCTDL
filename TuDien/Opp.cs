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
    public partial class Opp : Form
    {
        
        public Opp()
        {
            InitializeComponent();
            
            
        }

        private void Opp_Load(object sender, EventArgs e)
        {

        }
        private void picdemo_MouseEnter(object sender, EventArgs e)
        {
            this.picdemo.Image = global::TuDien.Properties.Resources.DEMO1;
        }
        private void picdemo_MouseLeave(object sender, EventArgs e)
        {
            this.picdemo.Image = global::TuDien.Properties.Resources.demo;
        }
        private void picdemo_Click(object sender, EventArgs e)
        {
            Demo dm = new Demo();
            dm.Show();
        }

        private void picdic_MouseEnter(object sender, EventArgs e)
        {
            this.picdic.Image = global::TuDien.Properties.Resources.DICTIONARY1;
        }

        private void picdic_MouseLeave(object sender, EventArgs e)
        {
            this.picdic.Image = global::TuDien.Properties.Resources.DIC;
        }

        private void picdic_Click(object sender, EventArgs e)
        {
            TuDien td = new TuDien();
            td.Show();
            
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::TuDien.Properties.Resources.Exit1;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.Image = global::TuDien.Properties.Resources.Exit2;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
