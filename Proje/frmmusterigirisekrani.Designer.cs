
namespace Proje
{
    partial class frmmusterigirisekrani
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
            this.geri_butonu_musteri_giris = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.seri_numarasi_submit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Giriş Ekranı";
            // 
            // geri_butonu_musteri_giris
            // 
            this.geri_butonu_musteri_giris.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.geri_butonu_musteri_giris.BackgroundImage = global::Proje.Properties.Resources.Adsız;
            this.geri_butonu_musteri_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.geri_butonu_musteri_giris.Location = new System.Drawing.Point(16, 366);
            this.geri_butonu_musteri_giris.Name = "geri_butonu_musteri_giris";
            this.geri_butonu_musteri_giris.Size = new System.Drawing.Size(72, 72);
            this.geri_butonu_musteri_giris.TabIndex = 8;
            this.geri_butonu_musteri_giris.UseVisualStyleBackColor = false;
            this.geri_butonu_musteri_giris.Click += new System.EventHandler(this.geri_butonu_musteri_giris_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 232);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(187, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Arıza seri numarası";
            // 
            // seri_numarasi_submit_btn
            // 
            this.seri_numarasi_submit_btn.Location = new System.Drawing.Point(469, 287);
            this.seri_numarasi_submit_btn.Name = "seri_numarasi_submit_btn";
            this.seri_numarasi_submit_btn.Size = new System.Drawing.Size(75, 23);
            this.seri_numarasi_submit_btn.TabIndex = 11;
            this.seri_numarasi_submit_btn.Text = "Onayla";
            this.seri_numarasi_submit_btn.UseVisualStyleBackColor = true;
            // 
            // frmmusterigirisekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.seri_numarasi_submit_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.geri_butonu_musteri_giris);
            this.Controls.Add(this.label1);
            this.Name = "frmmusterigirisekrani";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button geri_butonu_musteri_giris;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button seri_numarasi_submit_btn;
    }
}