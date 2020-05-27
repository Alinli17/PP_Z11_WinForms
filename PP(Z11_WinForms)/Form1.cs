using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z11_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class RegExp
        {
            private Regex r;
            private string text;

            public RegExp(string pattern, string txt)
            {
                r = new Regex(pattern);
                text = txt;
            }
            public string IsExist()
            {
                string s = "";
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                {
                    s = "Есть\n";
                    return s;
                }
                s = "Нет\n";
                return s;
            }

            public string ShowMatches()
            {
                string s = "";
                MatchCollection m = r.Matches(text);
                foreach (Match x in m)
                    s+="Нашлось совпадение с шаблоном:\n" + x.Value + "\n";
                return s;
            }

            public string DeleteMatches()
            {
                MatchCollection m = r.Matches(text);
                string s = text;
                foreach (Match x in m)
                {
                    int i = s.IndexOf(x.Value);
                    int l = x.Value.Length;

                    s = s.Remove(i, l);
                }
                Console.WriteLine(s);
                return s;
            }
            public Regex R
            {
                get { return r; }
                set { r = value; }
            }

            public string Text
            {
                get { return text; }
                set { text = value; }
            }
        }
        private void Result_Click(object sender, EventArgs e)
        {
            string text = "Мой телефон 8(926)123-45-67, а у мамы +7 926 123 45 67\n";
            string pattern = @"((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}";

            string s = "";
            s += "Строка текста:\n" + text + "\n";
            s += "Регулярное выражение:\n" + pattern + "\n";
            information.Text = s.ToString();

            RegExp My = new RegExp(pattern, text);

            t_or_f.Text = My.IsExist().ToString();
            print.Text = My.ShowMatches().ToString();
            remore.Text = My.DeleteMatches().ToString();

        }
    }
}
