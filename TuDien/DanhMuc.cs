using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Collections;

namespace TuDien
{
    class DanhMuc
    {
        public Hash[] ds = new Hash[26];
        private string[] dsFileName = new string[26];

        public DanhMuc()								//bộ khởi dựng 
        {
            dsFileName[0] = "a.txt"; dsFileName[1] = "b.txt"; dsFileName[2] = "c.txt"; dsFileName[3] = "d.txt";
            dsFileName[4] = "e.txt"; dsFileName[5] = "f.txt"; dsFileName[6] = "g.txt"; dsFileName[7] = "h.txt";
            dsFileName[8] = "i.txt"; dsFileName[9] = "j.txt"; dsFileName[10] = "k.txt"; dsFileName[11] = "l.txt";
            dsFileName[12] = "m.txt"; dsFileName[13] = "n.txt"; dsFileName[14] = "o.txt"; dsFileName[15] = "p.txt";
            dsFileName[16] = "q.txt"; dsFileName[17] = "r.txt"; dsFileName[18] = "s.txt"; dsFileName[19] = "t.txt";
            dsFileName[20] = "u.txt"; dsFileName[21] = "v.txt"; dsFileName[22] = "w.txt"; dsFileName[23] = "x.txt";
            dsFileName[24] = "y.txt"; dsFileName[25] = "z.txt";
            for (int i = 0; i < 26; i++)
            {
                ds[i] = new Hash(dsFileName[i]);
            }
        }
        public Hash this[int index]
        {
            get { return (Hash)ds[index]; }
        }
        #region thao tác với tập dữ liệu
        public void WriteToData()
        {
            foreach (Hash a in ds)
                a.WriteFile();
        }
        public void xoadata()
        {
            foreach (Hash a in ds)
                a.xoatrang();
        }
        public void ReadFromData()
        {
            foreach (Hash a in ds)
                a.ReadFile();
        }
        #endregion


        //
        public int hashkey(string key)
        {
            int i = 0;
            switch (key[0])
            {

                case 'a': i = 0; break;
                case 'b': i = 1; break;
                case 'c': i = 2; break;
                case 'd': i = 3; break;
                case 'e': i = 4; break;
                case 'f': i = 5; break;
                case 'g': i = 6; break;
                case 'h': i = 7; break;
                case 'i': i = 8; break;
                case 'j': i = 9; break;
                case 'k': i = 10; break;
                case 'l': i = 11; break;
                case 'm': i = 12; break;
                case 'n': i = 13; break;
                case 'o': i = 14; break;
                case 'p': i = 15; break;
                case 'q': i = 16; break;
                case 'r': i = 17; break;
                case 's': i = 18; break;
                case 't': i = 19; break;
                case 'u': i = 20; break;
                case 'v': i = 21; break;
                case 'w': i = 22; break;
                case 'x': i = 23; break;
                case 'y': i = 24; break;
                case 'z': i = 25; break;

            }
            return i;
        }
        public string writedata(string key)
        {
            string kq = "";
            int i = hashkey(key);
            kq = ds[i].SearchWord(key);
            return kq;
        }
        public void HienThiTuLienQuan(string key, ref string[] mangchuakey)
        {
            int i = hashkey(key);
            string[] keys = new string[100];
            int dem;
            ds[i].hienthitucolienquan(key, ref keys, out dem);
            for (int j = 0; j < dem; j++)
            {
                mangchuakey[j] = keys[j];
            }
        }

        public bool delete(string key)
        {
            int i = hashkey(key);
            if (ds[i].timkiem(key) == true)
            {
                ds[i].xoa(key);

                return true;

            }
            else return false;

        }
        public bool themtu(string key, string tuloai, string phatam, string nghia)
        {
            int i = hashkey(key);
            if (ds[i].timkiem(key) == false)
            {
                ds[i].AddWord(key, tuloai, phatam, nghia);
                return true;
            }
            else
                return false;

        }

    }
}
