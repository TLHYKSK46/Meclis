
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnListe = new System.Windows.Forms.Button();
            this.lblBelgeNo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Başlama Tarihi:";
            // 
            // dtBaslamaTarihi
            // 
            this.dtBaslamaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBaslamaTarihi.Location = new System.Drawing.Point(163, 118);
            this.dtBaslamaTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtBaslamaTarihi.Name = "dtBaslamaTarihi";
            this.dtBaslamaTarihi.Size = new System.Drawing.Size(261, 27);
            this.dtBaslamaTarihi.TabIndex = 41;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(50, 318);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(132, 49);
            this.btnKaydet.TabIndex = 42;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbVekilTanım
            // 
            this.cbVekilTanım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbVekilTanım.FormattingEnabled = true;
            this.cbVekilTanım.Location = new System.Drawing.Point(163, 21);
            this.cbVekilTanım.Margin = new System.Windows.Forms.Padding(2);
            this.cbVekilTanım.Name = "cbVekilTanım";
            this.cbVekilTanım.Size = new System.Drawing.Size(261, 28);
            this.cbVekilTanım.TabIndex = 45;
            this.cbVekilTanım.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbVekilTanım_Format);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 29);
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
            this.cbMazeretKod.Location = new System.Drawing.Point(163, 86);
            this.cbMazeretKod.Margin = new System.Windows.Forms.Padding(2);
            this.cbMazeretKod.Name = "cbMazeretKod";
            this.cbMazeretKod.Size = new System.Drawing.Size(261, 28);
            this.cbMazeretKod.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Mazeret Kodu:";
            // 
            // txtMazeretNedeni
            // 
            this.txtMazeretNedeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMazeretNedeni.Location = new System.Drawing.Point(163, 190);
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
            this.label5.Location = new System.Drawing.Point(13, 190);
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
            this.label6.Location = new System.Drawing.Point(13, 156);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Bitiş Tarihi:";
            // 
            // dtBitisTarihi
            // 
            this.dtBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtBitisTarihi.Location = new System.Drawing.Point(163, 149);
            this.dtBitisTarihi.Margin = new System.Windows.Forms.Padding(2);
            this.dtBitisTarihi.Name = "dtBitisTarihi";
            this.dtBitisTarihi.Size = new System.Drawing.Size(261, 27);
            this.dtBitisTarihi.TabIndex = 51;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBelgeNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.txtMazeretNedeni);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.dtBitisTarihi);
            this.groupBox1.Controls.Add(this.dtBaslamaTarihi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbMazeretKod);
            this.groupBox1.Controls.Add(this.cbVekilTanım);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(673, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 642);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mazeret Belge No";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(319, 318);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(109, 49);
            this.btnSil.TabIndex = 54;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(186, 318);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(129, 49);
            this.btnGuncelle.TabIndex = 53;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgListe
            // 
            this.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListe.Location = new System.Drawing.Point(13, 106);
            this.dgListe.Name = "dgListe";
            this.dgListe.Size = new System.Drawing.Size(654, 526);
            this.dgListe.TabIndex = 54;
            this.dgListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListe_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(12, 73);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(356, 27);
            this.txtAra.TabIndex = 55;
            // 
            // btnListe
            // 
            this.btnListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListe.Location = new System.Drawing.Point(417, 67);
            this.btnListe.Margin = new System.Windows.Forms.Padding(2);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(132, 33);
            this.btnListe.TabIndex = 56;
            this.btnListe.Text = "Listele";
            this.btnListe.UseVisualStyleBackColor = true;
            // 
            // lblBelgeNo
            // 
            this.lblBelgeNo.AutoSize = true;
            this.lblBelgeNo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBelgeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBelgeNo.Location = new System.Drawing.Point(161, 61);
            this.lblBelgeNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBelgeNo.Name = "lblBelgeNo";
            this.lblBelgeNo.Size = new System.Drawing.Size(45, 20);
            this.lblBelgeNo.TabIndex = 56;
            this.lblBelgeNo.Text = "0000";
            // 
            // FrmMazeretTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 656);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmMazeretTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMazeretTanim";
            this.Load += new System.EventHandler(this.FrmMazeretTanim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Label lblBelgeNo;
    }
}