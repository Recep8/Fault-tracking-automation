
namespace Proje
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.personel_giris_yap_buton = new System.Windows.Forms.Button();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.sifre_sifirlama_link_label = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Giriş Ekranı";
            // 
            // personel_giris_yap_buton
            // 
            this.personel_giris_yap_buton.Location = new System.Drawing.Point(501, 287);
            this.personel_giris_yap_buton.Name = "personel_giris_yap_buton";
            this.personel_giris_yap_buton.Size = new System.Drawing.Size(97, 40);
            this.personel_giris_yap_buton.TabIndex = 1;
            this.personel_giris_yap_buton.Text = "Giriş Yap";
            this.personel_giris_yap_buton.UseVisualStyleBackColor = true;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(237, 274);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(229, 20);
            this.email_textbox.TabIndex = 2;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(237, 322);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(229, 20);
            this.sifre_textbox.TabIndex = 3;
            // 
            // sifre_sifirlama_link_label
            // 
            this.sifre_sifirlama_link_label.AutoSize = true;
            this.sifre_sifirlama_link_label.Location = new System.Drawing.Point(277, 366);
            this.sifre_sifirlama_link_label.Name = "sifre_sifirlama_link_label";
            this.sifre_sifirlama_link_label.Size = new System.Drawing.Size(112, 13);
            this.sifre_sifirlama_link_label.TabIndex = 4;
            this.sifre_sifirlama_link_label.TabStop = true;
            this.sifre_sifirlama_link_label.Text = "Şifrenizi mi unuttunuz?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "E-MAİL";
            // 
            // sifre
            // 
            this.sifre.AutoSize = true;
            this.sifre.Location = new System.Drawing.Point(193, 325);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(38, 13);
            this.sifre.TabIndex = 6;
            this.sifre.Text = "ŞİFRE";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifre_sifirlama_link_label);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.personel_giris_yap_buton);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button personel_giris_yap_buton;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.LinkLabel sifre_sifirlama_link_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sifre;
    }
}