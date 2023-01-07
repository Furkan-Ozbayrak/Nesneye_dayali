namespace Nesneye_Dayalı
{
    partial class ekok
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.text_girdi = new System.Windows.Forms.TextBox();
            this.text_girdi_2 = new System.Windows.Forms.TextBox();
            this.ekkoo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text_girdi
            // 
            this.text_girdi.Location = new System.Drawing.Point(183, 136);
            this.text_girdi.Name = "text_girdi";
            this.text_girdi.Size = new System.Drawing.Size(100, 20);
            this.text_girdi.TabIndex = 0;
            // 
            // text_girdi_2
            // 
            this.text_girdi_2.Location = new System.Drawing.Point(334, 136);
            this.text_girdi_2.Name = "text_girdi_2";
            this.text_girdi_2.Size = new System.Drawing.Size(100, 20);
            this.text_girdi_2.TabIndex = 1;
            // 
            // ekkoo
            // 
            this.ekkoo.Location = new System.Drawing.Point(270, 180);
            this.ekkoo.Name = "ekkoo";
            this.ekkoo.Size = new System.Drawing.Size(75, 23);
            this.ekkoo.TabIndex = 2;
            this.ekkoo.Text = "Hesapla";
            this.ekkoo.UseVisualStyleBackColor = true;
            this.ekkoo.Click += new System.EventHandler(this.ekkoo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(539, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ana Sayfaya Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ekok\'u bulunucak sayıları giriniz.";
            // 
            // ekok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ekkoo);
            this.Controls.Add(this.text_girdi_2);
            this.Controls.Add(this.text_girdi);
            this.Name = "ekok";
            this.Text = "ekok";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_girdi;
        private System.Windows.Forms.TextBox text_girdi_2;
        private System.Windows.Forms.Button ekkoo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}