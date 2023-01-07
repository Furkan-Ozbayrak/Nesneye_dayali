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
    public partial class MukemmelSayı : Form
    {
        public MukemmelSayı()
        {
            InitializeComponent();
        }

        private void Mukemmel_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            
            int sayi = 0;
            int Sonuc = 0;
            sayi = Convert.ToInt16(textBox1.Text);
            String Write = "Mukemmel Sayı mı : " + sayi;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);
            if (sayi>0)
            {
                for(int i = 1; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {

                        Sonuc=Sonuc+i;

                      
                    }
                    
                    


                    

                }
                if (Sonuc == sayi)
                {
                    MessageBox.Show("  " + Sonuc + " " + "mukemmel sayıdır");
                    String Write2 = " " + Sonuc+" "+" mukemmel sayıdır";
                    FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    fs2.Close();
                    File.AppendAllText(filename, Environment.NewLine + Write2);

                }

                else
                {
                    MessageBox.Show( "mukemel sayı değildir.");
                     
                    String Write3 = " " + sayi + " " + " mukemmel sayı değildir";
                    FileStream fs3 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    fs3.Close();
                    File.AppendAllText(filename, Environment.NewLine + Write3);

                }


            }
            else
            {
                String Write4 = " Lütfen pozitif sayı giriniz .";
                FileStream fs4 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs4.Close();
                File.AppendAllText(filename, Environment.NewLine + Write4);
                MessageBox.Show("Lütfen Pozitif Sayı Giriniz " );


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
