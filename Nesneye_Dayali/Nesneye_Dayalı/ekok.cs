using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayalı
{
    public partial class ekok : Form
    {
        public ekok()
        {
            InitializeComponent();
        }

        private void ekkoo_Click(object sender, EventArgs e)
        {

            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            int a = 0;
            int b = 0;
            int ekok = 0;
            a = Convert.ToInt16(text_girdi.Text);
            b = Convert.ToInt16(text_girdi_2.Text);
            String Write = "EKOK bul:  " + a + " " + b;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            int max = a * b;


            for (int i = max; i >0; i--)
            {
                if (i % a == 0 && i % b == 0)
                {
                    ekok = i;

                }

            }
            MessageBox.Show(" " + ekok);
            String Write2 = "  " + ekok;
            FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs2.Close();
            File.AppendAllText(filename, Environment.NewLine + Write2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa mahmut = new AnaSayfa();
            mahmut.Show();
            this.Hide();
        }
    }
    }

