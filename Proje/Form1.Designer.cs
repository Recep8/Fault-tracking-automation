
namespace Proje
{
    partial class Form1
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.personel_giris_buton = new System.Windows.Forms.Button();
            this.musteri_giris_buton = new System.Windows.Forms.Button();
            this.yonetici_giris_buton = new System.Windows.Forms.Button();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.yonetici_giris_buton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.musteri_giris_buton);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.personel_giris_buton);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 433);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 458);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // personel_giris_buton
            // 
            this.personel_giris_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.personel_giris_buton.Location = new System.Drawing.Point(289, 297);
            this.personel_giris_buton.Name = "personel_giris_buton";
            this.personel_giris_buton.Size = new System.Drawing.Size(208, 86);
            this.personel_giris_buton.TabIndex = 0;
            this.personel_giris_buton.Text = "Personel Girişi";
            this.personel_giris_buton.UseVisualStyleBackColor = true;
            this.personel_giris_buton.Click += new System.EventHandler(this.personel_giris_buton_Click);
            // 
            // musteri_giris_buton
            // 
            this.musteri_giris_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.musteri_giris_buton.Location = new System.Drawing.Point(546, 297);
            this.musteri_giris_buton.Name = "musteri_giris_buton";
            this.musteri_giris_buton.Size = new System.Drawing.Size(208, 86);
            this.musteri_giris_buton.TabIndex = 1;
            this.musteri_giris_buton.Text = "Müşteri Girişi";
            this.musteri_giris_buton.UseVisualStyleBackColor = true;
            this.musteri_giris_buton.Click += new System.EventHandler(this.musteri_giris_buton_Click);
            // 
            // yonetici_giris_buton
            // 
            this.yonetici_giris_buton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yonetici_giris_buton.Location = new System.Drawing.Point(30, 297);
            this.yonetici_giris_buton.Name = "yonetici_giris_buton";
            this.yonetici_giris_buton.Size = new System.Drawing.Size(208, 86);
            this.yonetici_giris_buton.TabIndex = 2;
            this.yonetici_giris_buton.Text = "Yönetici Girişi";
            this.yonetici_giris_buton.UseVisualStyleBackColor = true;
            this.yonetici_giris_buton.Click += new System.EventHandler(this.yonetici_giris_buton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = " ";
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Button musteri_giris_buton;
        private System.Windows.Forms.Button personel_giris_buton;
        private System.Windows.Forms.Button yonetici_giris_buton;
    }
}

