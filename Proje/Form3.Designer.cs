
namespace Proje
{
    partial class Form3
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
            this.yeni_ariza_kayit_musteri_buton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Giriş Ekranı";
            // 
            // yeni_ariza_kayit_musteri_buton
            // 
            this.yeni_ariza_kayit_musteri_buton.Location = new System.Drawing.Point(128, 266);
            this.yeni_ariza_kayit_musteri_buton.Name = "yeni_ariza_kayit_musteri_buton";
            this.yeni_ariza_kayit_musteri_buton.Size = new System.Drawing.Size(202, 106);
            this.yeni_ariza_kayit_musteri_buton.TabIndex = 1;
            this.yeni_ariza_kayit_musteri_buton.Text = "Yeni bir arıza kaydı eklemek için";
            this.yeni_ariza_kayit_musteri_buton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(442, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 106);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cihaz durumu öğrenmek için";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.yeni_ariza_kayit_musteri_buton);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yeni_ariza_kayit_musteri_buton;
        private System.Windows.Forms.Button button2;
    }
}