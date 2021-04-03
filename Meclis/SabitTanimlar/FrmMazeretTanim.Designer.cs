
namespace Meclis.SabitTanimlar
{
    partial class FrmMazeretTanim
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
            this.label4 = new System.Windows.Forms.Label();
            this.dtBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbVekilTanım = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMazeretKod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMazeretNedeni = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Başlama Tarihi:";
            // 
            // dtBaslamaTarihi
            // 
            this.dtBaslamaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslamaTarihi.Location = new System.Drawing.Point(227, 76);
            this.dtBaslamaTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaslamaTarihi.Name = "dtBaslamaTarihi";
            this.dtBaslamaTarihi.Size = new System.Drawing.Size(261, 27);
            this.dtBaslamaTarihi.TabIndex = 41;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(356, 246);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 32);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbVekilTanım
            // 
            this.cbVekilTanım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbVekilTanım.FormattingEnabled = true;
            this.cbVekilTanım.Location = new System.Drawing.Point(227, 12);
            this.cbVekilTanım.Margin = new System.Windows.Forms.Padding(2);
            this.cbVekilTanım.Name = "cbVekilTanım";
            this.cbVekilTanım.Size = new System.Drawing.Size(261, 28);
            this.cbVekilTanım.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(37, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Vekil:";
            // 
            // cbMazeretKod
            // 
            this.cbMazeretKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMazeretKod.FormattingEnabled = true;
            this.cbMazeretKod.Location = new System.Drawing.Point(227, 44);
            this.cbMazeretKod.Margin = new System.Windows.Forms.Padding(2);
            this.cbMazeretKod.Name = "cbMazeretKod";
            this.cbMazeretKod.Size = new System.Drawing.Size(261, 28);
            this.cbMazeretKod.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(37, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mazeret Kodu:";
            // 
            // txtMazeretNedeni
            // 
            this.txtMazeretNedeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMazeretNedeni.Location = new System.Drawing.Point(227, 148);
            this.txtMazeretNedeni.Margin = new System.Windows.Forms.Padding(2);
            this.txtMazeretNedeni.Multiline = true;
            this.txtMazeretNedeni.Name = "txtMazeretNedeni";
            this.txtMazeretNedeni.Size = new System.Drawing.Size(261, 82);
            this.txtMazeretNedeni.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(37, 148);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Mazeret Nedeni:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(37, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Bitiş Tarihi:";
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisTarihi.Location = new System.Drawing.Point(227, 107);
            this.dtBitisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(261, 27);
            this.dtBitisTarihi.TabIndex = 51;
            // 
            // FrmMazeretTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 298);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtBitisTarihi);
            this.Controls.Add(this.txtMazeretNedeni);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMazeretKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbVekilTanım);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtBaslamaTarihi);
            this.Controls.Add(this.btnKaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMazeretTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMazeretTanim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtBaslamaTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.ComboBox cbVekilTanım;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMazeretKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMazeretNedeni;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtBitisTarihi;
    }
}