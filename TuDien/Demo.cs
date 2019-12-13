using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections;

namespace TuDien
{
    public partial class Demo : Form
    {
        System.Media.SoundPlayer nhac = new System.Media.SoundPlayer();
        public Demo()
        {
            InitializeComponent();
            nhac.SoundLocation = "NHACDAO.wav";
            nhac.Play();
        }

        private void Demo_Load(object sender, EventArgs e)
        {

        }
        MD5 md = MD5.Create();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboHash.Text=="MD5")
            {
                byte[] input = System.Text.Encoding.ASCII.GetBytes(Inputa.Text);
                byte[] hash = md.ComputeHash(input);
                StringBuilder sb = new StringBuilder();
                for(int i=0;i<hash.Length;i++)
                {
                    sb.Append(hash[i].ToString("X2"));
                    Output.Text = sb.ToString();
                }
            }
            else if(comboHash.Text=="SHA-1")
            {
                SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
                sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(Inputa.Text));
                byte[] sb = sh.Hash;
                StringBuilder st = new StringBuilder();
                foreach(byte b in sb)
                {
                    st.Append(b.ToString("X2"));
                    Output.Text = st.ToString();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
