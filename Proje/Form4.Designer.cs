
namespace Proje
{
    partial class Form4
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
            this.yonetici_giris_ekrani_baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // yonetici_giris_ekrani_baslik
            // 
            this.yonetici_giris_ekrani_baslik.AutoSize = true;
            this.yonetici_giris_ekrani_baslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici_giris_ekrani_baslik.Location = new System.Drawing.Point(13, 13);
            this.yonetici_giris_ekrani_baslik.Name = "yonetici_giris_ekrani_baslik";
            this.yonetici_giris_ekrani_baslik.Size = new System.Drawing.Size(198, 24);
            this.yonetici_giris_ekrani_baslik.TabIndex = 0;
            this.yonetici_giris_ekrani_baslik.Text = "Yönetici Giriş Ekranı";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.yonetici_giris_ekrani_baslik);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yonetici_giris_ekrani_baslik;
    }
}