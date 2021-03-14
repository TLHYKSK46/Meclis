
namespace Meclis.SabitTanimlar
{
    partial class FrmKomisyonTanim
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtUluslararasiAdi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIhtisasAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Uluslararası Adı:";
            // 
            // txtUluslararasiAdi
            // 
            this.txtUluslararasiAdi.Location = new System.Drawing.Point(161, 62);
            this.txtUluslararasiAdi.Name = "txtUluslararasiAdi";
            this.txtUluslararasiAdi.Size = new System.Drawing.Size(185, 26);
            this.txtUluslararasiAdi.TabIndex = 2;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(193, 143);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 42);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "İhtisas Adı:";
            // 
            // txtIhtisasAdi
            // 
            this.txtIhtisasAdi.Location = new System.Drawing.Point(161, 30);
            this.txtIhtisasAdi.Name = "txtIhtisasAdi";
            this.txtIhtisasAdi.Size = new System.Drawing.Size(185, 26);
            this.txtIhtisasAdi.TabIndex = 1;
            // 
            // FrmKomisyonTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUluslararasiAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIhtisasAdi);
            this.MaximizeBox = false;
            this.Name = "FrmKomisyonTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKomisyonTanim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUluslararasiAdi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIhtisasAdi;
    }
}