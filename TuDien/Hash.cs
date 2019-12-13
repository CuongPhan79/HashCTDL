using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Windows.Forms;

namespace TuDien
{
    class Hash
    {
        public Hashtable ds = new Hashtable();
        public string fileName = "";
        public Hash()
        {
        }
        public Hash(string tenfile)
        {
            fileName = tenfile;
        }
        public Word this[int cs]
        {
            get { return (Word)ds[cs]; }
        }
        //them 1 tu gom có key và value
        public void AddWord(string key, Word value)
        {
            ds.Add(key, value);
        }

        //hoac la truyen tat ca tham so
        public void AddWord(string key, string tuloai, string phatam, string nghia)
        {
            Word a = new Word(key, tuloai, phatam, nghia);
            ds.Add(key, a);
        }



        #region thao tác với file
        public void WriteFile()					// ghi ra file text
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            FileStream myFile = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(myFile);
            Word w;
            //string s =  w.tuloai + w.phatam  + w.nghia;

            foreach (DictionaryEntry a in ds)
            {
                w = (Word)a.Value;
                sw.WriteLine(w.Key + "-" + w.Tuloai + "-" + w.Phatam + "-" + w.Nghia);
                sw.Flush();
            }
            sw.Close();
            myFile.Close();
        }

        public void xoatrang()
        {
            if (File.Exists(fileName)) File.Delete(fileName);
            FileStream myFile = new FileStream(fileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(myFile);
            //Word w = new Word();
            string s = "";

            foreach (DictionaryEntry a in ds)
            {
                sw.WriteLine(s);
                sw.Flush();
            }
            sw.Close();
            myFile.Close();
        }

        public void ReadFile()
        {
            string text;
            string[] tam;
            FileStream myFile;
            if (File.Exists(fileName))
            {
                myFile = new FileStream(fileName, FileMode.Open);
                StreamReader sr = new StreamReader(myFile);
                for (; (text = sr.ReadLine()) != null;)
                {
                    tam = text.Split('-');
                    AddWord(tam[0], tam[1], tam[2], tam[3]);
                }
                sr.Close();
                myFile.Close();
            }
            else myFile = new FileStream(fileName, FileMode.Create);
        }

        #endregion
        //tim kiem tu khoa trong 1 muc tu
        public string SearchWord(string key)
        {
            string s = "";
            ICollection c = ds.Keys;
            foreach (string item in c)
            {

                if (item == key)
                {
                    s = item + " :  " + "\n" + ds[item].ToString();

                    break;
                }

            }
            return s;
        }

        //int ket qua
        public override string ToString()
        {
            string kq = "";

            IDictionaryEnumerator enumerator = ds.GetEnumerator();
            while (enumerator.MoveNext())
            {
                kq = enumerator.Key + " : " + enumerator.Value.ToString();
            }
            return kq;

        }

        //xay dung cac ham them xoa sua
        //1.xoa
        public Boolean xoa(string key)
        {
            if (ds.ContainsKey(key))
            {
                ds.Remove(key);
                return true;
            }
            else
                return false;

        }
        //1.ham tim kiem
        public Boolean timkiem(string key)
        {
            if (ds.ContainsKey(key))
                return true;
            else return false;
        }
        //int toan bo tu khoa
        public string intoanbo()
        {
            string s = "";
            ICollection c = ds.Keys;
            foreach (string item in c)
            {
                s = s + item + "\n";
            }
            return s;
        }

        public void inkey(ref string[] s)
        {
            int i = 0;
            s = new string[ds.Keys.Count];
            ICollection c = ds.Keys;
            foreach (string item in c)
            {
                s[i] = item;
                ++i;
            }
        }
        //xuat tung item vao list
        public void hienthitucolienquan(string key, ref string[] keys, out int dem)
        {
            dem = 0;
            int i = 0;
            ICollection c = ds.Keys;
            foreach (string item in c)
            {
                if (item.Contains(key))
                {
                    keys[i] = item;
                    i++;
                    dem++;
                }

            }


        }
    }
}
