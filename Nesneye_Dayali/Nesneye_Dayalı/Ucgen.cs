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
    
    public partial class Ucgen : Form
    {
        public Ucgen()
        {
            InitializeComponent();
        }

        private void button_ucgen_Click(object sender, EventArgs e)
        {
            String filename = @"C:\Users\Furkan\Desktop\Nesneye_Dayalı\Nesneye_Dayalı\cikti.txt";

            int a = 0;
            int b = 0;
            int c = 0;
            int toplam = 0;
            int fark = 0;
            a = Convert.ToInt16(text_ucgen_1.Text); 
            b = Convert.ToInt16(text_ucgen2.Text);   
            c = Convert.ToInt16(text_ucgen3.Text);
            String Write = "Ucgen mi  : " +a+" "+ b + " " + c ;
            FileStream fs = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
            fs.Close();
            File.AppendAllText(filename, Environment.NewLine + Write);

            if (((a+b)>c) && ((a+c)>b) && ((b+c)>a)) { 
                {
          

                    MessageBox.Show("Girilen değerler UCGEN");
                    String Write2 = "Ucgen "  ;
                    FileStream fs2 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                    fs2.Close();
                    File.AppendAllText(filename, Environment.NewLine + Write2);


                }

            }
             else {

                MessageBox.Show("Girilen değerler UCGEN DEGIL ");
                String Write3 = "UCGEN DEGIL ";
                FileStream fs3 = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.Write);
                fs3.Close();
                File.AppendAllText(filename, Environment.NewLine + Write3);


            }

        }

        private void Form1_Load(object sender, EventArgs e)
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
