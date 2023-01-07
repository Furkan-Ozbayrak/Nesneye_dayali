namespace Nesneye_Dayalı
{
    partial class Ucgen
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_ucgen_1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text_ucgen2 = new System.Windows.Forms.TextBox();
            this.text_ucgen3 = new System.Windows.Forms.TextBox();
            this.button_ucgen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_ucgen_1
            // 
            this.text_ucgen_1.Location = new System.Drawing.Point(224, 146);
            this.text_ucgen_1.Name = "text_ucgen_1";
            this.text_ucgen_1.Size = new System.Drawing.Size(58, 20);
            this.text_ucgen_1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Üçgen değerlerini giriniz";
            // 
            // text_ucgen2
            // 
            this.text_ucgen2.Location = new System.Drawing.Point(308, 146);
            this.text_ucgen2.Name = "text_ucgen2";
            this.text_ucgen2.Size = new System.Drawing.Size(54, 20);
            this.text_ucgen2.TabIndex = 2;
            // 
            // text_ucgen3
            // 
            this.text_ucgen3.Location = new System.Drawing.Point(393, 146);
            this.text_ucgen3.Name = "text_ucgen3";
            this.text_ucgen3.Size = new System.Drawing.Size(58, 20);
            this.text_ucgen3.TabIndex = 3;
            // 
            // button_ucgen
            // 
            this.button_ucgen.Location = new System.Drawing.Point(252, 200);
            this.button_ucgen.Name = "button_ucgen";
            this.button_ucgen.Size = new System.Drawing.Size(171, 28);
            this.button_ucgen.TabIndex = 4;
            this.button_ucgen.Text = "ucgen karşılaştırma";
            this.button_ucgen.UseVisualStyleBackColor = true;
            this.button_ucgen.Click += new System.EventHandler(this.button_ucgen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ana Sayfaya Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Ucgen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_ucgen);
            this.Controls.Add(this.text_ucgen3);
            this.Controls.Add(this.text_ucgen2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_ucgen_1);
            this.Name = "Ucgen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_ucgen_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_ucgen2;
        private System.Windows.Forms.TextBox text_ucgen3;
        private System.Windows.Forms.Button button_ucgen;
        private System.Windows.Forms.Button button2;
    }
}

