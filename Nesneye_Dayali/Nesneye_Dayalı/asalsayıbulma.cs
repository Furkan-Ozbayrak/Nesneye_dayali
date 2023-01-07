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
    public partial class asalsayıbulma : Form
    {
        public asalsayıbulma()
        {
            InitializeComponent();
        }

        private void asalsayı_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            int ilk = 0;
            int son = 0;
            int Sonuc = 0;
            ilk = Convert.ToInt16(textBox1.Text);
            son = Convert.ToInt16(textBox2.Text);
            String Write = "En buyuk asal sayiyi bul  : " + " " + "["+ilk+" "+son+"]";
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);
            if (ilk <= son) {   
                for(int i = 2; i < son; i++)  
                {
                if (son % i == 0)
                {
                        son--;
                        i = 2;
                      
                    }
                    else
                    {
                        son = son;

                    }
                    
                }
                ilk++;
                              }

            MessageBox.Show(" " + son);
            String Write2 = " " + son;
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
