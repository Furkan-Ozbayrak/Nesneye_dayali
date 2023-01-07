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
    public partial class Hipotenüs : Form
    {
        public Hipotenüs()
        {
            InitializeComponent();
        }

        private void hipo_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";
            double ilk= 0;
            double a =0;
            double b=0 ;
            double son =0 ;
            double c = 0; ;
            double hipotenüs = 1;
            ilk = Convert.ToDouble(textBox1.Text);
            son = Convert.ToDouble(textBox2.Text);
            String Write = "Hipotenus uzunluğu hesapla: " + ilk+" " +son ;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            a = (ilk * ilk);            
            b= (son * son);
            c = a + b; 
            hipotenüs =Math.Sqrt(c);
            MessageBox.Show(" " + hipotenüs);
            String Write2 = " " + hipotenüs;
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
