
namespace Meclis.SabitTanimlar
{
    partial class FrmVekilDanisman
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
            this.cbVekil = new System.Windows.Forms.ComboBox();
            this.cbDanisman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSira = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(181, 103);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(102, 27);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vekil:";
            // 
            // cbVekil
            // 
            this.cbVekil.FormattingEnabled = true;
            this.cbVekil.Location = new System.Drawing.Point(99, 14);
            this.cbVekil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbVekil.Name = "cbVekil";
            this.cbVekil.Size = new System.Drawing.Size(151, 21);
            this.cbVekil.TabIndex = 1;
            // 
            // cbDanisman
            // 
            this.cbDanisman.FormattingEnabled = true;
            this.cbDanisman.Location = new System.Drawing.Point(99, 36);
            this.cbDanisman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDanisman.Name = "cbDanisman";
            this.cbDanisman.Size = new System.Drawing.Size(151, 21);
            this.cbDanisman.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danişman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sıra:";
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(99, 58);
            this.txtSira.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(151, 20);
            this.txtSira.TabIndex = 23;
            // 
            // FrmVekilDanisman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 138);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDanisman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVekil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmVekilDanisman";
            this.Text = "FrmVekilDanisman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbVekil;
        private System.Windows.Forms.ComboBox cbDanisman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSira;
    }
}