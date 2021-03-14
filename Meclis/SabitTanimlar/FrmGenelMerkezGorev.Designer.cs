
namespace Meclis.SabitTanimlar
{
    partial class FrmGenelMerkezGorev
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGenelMerkezGorevAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(192, 70);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 27);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Genel Merkez Görev Adı:";
            // 
            // txtGenelMerkezGorevAdi
            // 
            this.txtGenelMerkezGorevAdi.Location = new System.Drawing.Point(133, 23);
            this.txtGenelMerkezGorevAdi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGenelMerkezGorevAdi.Name = "txtGenelMerkezGorevAdi";
            this.txtGenelMerkezGorevAdi.Size = new System.Drawing.Size(161, 20);
            this.txtGenelMerkezGorevAdi.TabIndex = 1;
            // 
            // FrmGenelMerkezGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 119);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGenelMerkezGorevAdi);
            this.Controls.Add(this.btnKaydet);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmGenelMerkezGorev";
            this.Text = "FrmGenelMerkezGorev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGenelMerkezGorevAdi;
    }
}