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
    public partial class KuvvetBulma : Form
    {
        public KuvvetBulma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            int taban = 0;
            int ust = 0;
            int Sonuc = 1;
            taban = Convert.ToInt16(textBox1.Text);
            ust = Convert.ToInt16(textBox2.Text);
            String Write1 = " n'nin k. kuvetini bul:  " +taban + " " + ust ;
            FileStream fs1 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs1.Close();
            File.AppendAllText(filename, Environment.NewLine + Write1);


            if (ust > 0)
                {   for (int i = 0; i < ust; i++)
                    Sonuc = Sonuc * taban; 
                MessageBox.Show("" + Sonuc);

                String Write2 = "   " +  Sonuc;
                FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs2.Close();
                File.AppendAllText(filename, Environment.NewLine + Write2);


            }

            else if (ust == 0)
                {
                    Sonuc = 0;
                MessageBox.Show(" " + Sonuc);
                String Write3 = "   " + Sonuc;
                FileStream fs3 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs3.Close();
                File.AppendAllText(filename, Environment.NewLine + Write3);

            }
                else
                {
                for (int i = 0; i > ust; i--)
                    Sonuc = Sonuc * taban;
                MessageBox.Show("1/" + Sonuc);

                String Write3 = "1/   " + Sonuc;
                FileStream fs3 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs3.Close();
                File.AppendAllText(filename, Environment.NewLine + Write3);


            }
               
            }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa mahmut = new AnaSayfa();
            mahmut.Show();
            this.Hide();
        }
    }
    }

