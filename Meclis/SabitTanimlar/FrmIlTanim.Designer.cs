
namespace Meclis.SabitTanimlar
{
    partial class FrmIlTanim
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
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIlKodu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIlAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIlBolgesi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(210, 188);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 42);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "İl Kodu:";
            // 
            // txtIlKodu
            // 
            this.txtIlKodu.Location = new System.Drawing.Point(164, 33);
            this.txtIlKodu.Name = "txtIlKodu";
            this.txtIlKodu.Size = new System.Drawing.Size(185, 26);
            this.txtIlKodu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "İl Adı:";
            // 
            // txtIlAdi
            // 
            this.txtIlAdi.Location = new System.Drawing.Point(164, 65);
            this.txtIlAdi.Name = "txtIlAdi";
            this.txtIlAdi.Size = new System.Drawing.Size(185, 26);
            this.txtIlAdi.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "İl Bölgesi:";
            // 
            // txtIlBolgesi
            // 
            this.txtIlBolgesi.FormattingEnabled = true;
            this.txtIlBolgesi.Location = new System.Drawing.Point(164, 97);
            this.txtIlBolgesi.Name = "txtIlBolgesi";
            this.txtIlBolgesi.Size = new System.Drawing.Size(185, 28);
            this.txtIlBolgesi.TabIndex = 3;
            // 
            // FrmIlTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 242);
            this.Controls.Add(this.txtIlBolgesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIlAdi);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIlKodu);
            this.MaximizeBox = false;
            this.Name = "FrmIlTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIlTanim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIlKodu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIlAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtIlBolgesi;
    }
}