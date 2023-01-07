using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayalı
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void Tas_kagıt_makas_Click(object sender, EventArgs e)
        {
            TKM mahmut = new TKM();
            mahmut.Show();
            this.Hide();
            
        }

        private void Ucgen_Click(object sender, EventArgs e)
        {
            Ucgen mahmut = new Ucgen();
            mahmut.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ebob mahmut = new ebob();
            mahmut.Show();
            this.Hide();

        }

        private void ekok_Click(object sender, EventArgs e)
        {
            ekok mahmut = new ekok();
            mahmut.Show();
            this.Hide();
        }

        private void kuvvetBulma_Click(object sender, EventArgs e)
        {
            KuvvetBulma mahmut = new KuvvetBulma();
            mahmut.Show();
            this.Hide();
        }

        private void asalsayıbulma_Click(object sender, EventArgs e)
        {
            asalsayıbulma mahmut = new asalsayıbulma();
            mahmut.Show();
            this.Hide();
        }

        private void hipo_Click(object sender, EventArgs e)
        {
            Hipotenüs mahmut = new Hipotenüs();
            mahmut.Show();
            this.Hide();
        }

        private void MukemmelSayı_Click(object sender, EventArgs e)
        {
            MukemmelSayı mahmut = new MukemmelSayı();
            mahmut.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AkrepYelkovan mahmut = new AkrepYelkovan();
            mahmut.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Altdzgi mahmut = new Altdzgi();
            mahmut.Show();
            this.Hide();
        }
    }
    }

