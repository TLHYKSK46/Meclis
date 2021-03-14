
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
            this.btnKaydet.Location = new System.Drawing.Point(271, 158);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(153, 42);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Vekil:";
            // 
            // cbVekil
            // 
            this.cbVekil.FormattingEnabled = true;
            this.cbVekil.Location = new System.Drawing.Point(148, 21);
            this.cbVekil.Name = "cbVekil";
            this.cbVekil.Size = new System.Drawing.Size(224, 28);
            this.cbVekil.TabIndex = 1;
            // 
            // cbDanisman
            // 
            this.cbDanisman.FormattingEnabled = true;
            this.cbDanisman.Location = new System.Drawing.Point(148, 55);
            this.cbDanisman.Name = "cbDanisman";
            this.cbDanisman.Size = new System.Drawing.Size(224, 28);
            this.cbDanisman.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Danişman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Sıra:";
            // 
            // txtSira
            // 
            this.txtSira.Location = new System.Drawing.Point(148, 89);
            this.txtSira.Name = "txtSira";
            this.txtSira.Size = new System.Drawing.Size(224, 26);
            this.txtSira.TabIndex = 23;
            // 
            // FrmVekilDanisman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 212);
            this.Controls.Add(this.txtSira);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDanisman);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVekil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label1);
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