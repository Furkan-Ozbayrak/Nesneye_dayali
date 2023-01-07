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
    public partial class ebob : Form
    {
        public ebob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            int a = 0;
            int b = 0;
            int ebob = 0;
            a = Convert.ToInt16(textBox_1.Text);
            b = Convert.ToInt16(textBox_2.Text);

            String Write = "EBOB bul:  " + a + " " + b;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            for (int i  =1; i<a;i++) { 
              if(a%i == 0 && b%i == 0)
                {
                    ebob = i;

                }
              
            }
            MessageBox.Show(" " + ebob);

            String Write2 = "  " + ebob;
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
