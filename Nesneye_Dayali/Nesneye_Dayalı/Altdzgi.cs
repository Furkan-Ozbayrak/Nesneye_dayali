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
    public partial class Altdzgi : Form
    {
        public Altdzgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ilk = textBox1.Text; 
            string ikinci = textBox2.Text;
            

            int varmı = 0;
            bool varsa = ikinci.Contains(ilk);
            String filename = @"C:\Users\Furkan\source\repos\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            String Write = "Altdizgi mi :  " + ilk + " " + ikinci;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            if (varsa == true)
            {
                MessageBox.Show("altdizgidir  " );
                String Write2 = "ALTDIZGI " ;
                FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs2.Close();
                File.AppendAllText(filename, Environment.NewLine + Write2);


            }
           
            else
            {

                MessageBox.Show(" altdizgi değildir. 1  " );
                String Write3 = "ALTDIZGI DEGILDIR ";
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
