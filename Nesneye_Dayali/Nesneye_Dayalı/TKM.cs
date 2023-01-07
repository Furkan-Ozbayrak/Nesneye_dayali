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
    public partial class TKM : Form
    {
        public TKM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            String ilk = text_girdi1.Text;
            String ikinci = text_girdi2.Text;
            String Write = "Kagit Tas Makas Oyunu : " + ilk + " " + ikinci;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);


            if (ilk == "Kağıt" && ikinci == "Tas" || ilk == "Makas" && ikinci == "Kağıt" || ilk == "Tas" && ikinci == "Makas")
            {
                String Write2 = "Yendi " ;
                FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs2.Close();
                File.AppendAllText(filename, Environment.NewLine + Write2);

                MessageBox.Show(" YENDI ");

            }
            else {
                MessageBox.Show(" Yenemez ");
                String Write3 = "YENEMEDI ";
                FileStream fs3 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs3.Close();
                File.AppendAllText(filename, Environment.NewLine + Write3);

                
            }


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaSayfa mahmut = new AnaSayfa();
            mahmut.Show();
            this.Hide();
        }
    }
}
