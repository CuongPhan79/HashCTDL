using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;

namespace TuDien
{
    class Word
    {
        private string key;

        public string Key
        {
            get { return key; }
            set { key = value; }
        }
        public string tuloai;
        public string phatam;
        public string nghia;

        public string Tuloai
        {
            get { return tuloai; }
            set { tuloai = value; }
        }
        public string Phatam
        {
            get { return phatam; }
            set { phatam = value; }
        }
        public string Nghia
        {
            get { return nghia; }
            set { nghia = value; }
        }
        public Word()
        {
        }
        public Word(string K, string TL, string PA, string N)
        {
            key = K;
            tuloai = TL;
            phatam = PA;
            nghia = N;
        }
        public Word(string k)
        {
            key = k;
        }
        //int ra
        public override string ToString()
        {
            string s = "";
            s = tuloai + phatam + nghia;
            return s;


        }
    }
}
