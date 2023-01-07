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
    public partial class AkrepYelkovan : Form
    {
        public AkrepYelkovan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            int dakika = 0;
            int saat = 0;
            int Sonuc = 0;
            saat = Convert.ToInt16(textBox_saat.Text);
            dakika = Convert.ToInt16(textBox_dakika.Text);
            String Write = "Akrepe yelkovan arasindaki dar aciyi bul:  " + saat + " " + dakika ;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            if (saat >= 12)
                {
                    saat = saat - 12;
                }
                
            int x = saat * 30;   // 12 *30 = 360
            int y = (dakika * 30)/60;// // 0/60 = 0
            int akrep = x + y;
            int yelkovan = 6 * dakika;
         
            if (akrep == yelkovan)
            {
                Sonuc = 0;

            }
            else if (akrep > yelkovan)
            {
                Sonuc = akrep - yelkovan;
              
               
            }
            else
            {

                Sonuc = yelkovan - akrep;
            }
            MessageBox.Show("Aradaki açı " +Sonuc );
            String Write2 = "  " + Sonuc;
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
