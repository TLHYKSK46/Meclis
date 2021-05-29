
namespace Meclis.SabitTanimlar
{
    partial class FrmVekilDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vekilId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbGenelMerkezGorev = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cbMeslek = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.cbMeclisGorev = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDostlukGrup = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDonem = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPartiGrup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbParti = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbIl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbKomisyonDurum = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOdaNo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vekilId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cbGenelMerkezGorev);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.cbMeslek);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbMeclisGorev);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbDostlukGrup);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbDonem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbPartiGrup);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbParti);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbIl);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbKomisyonDurum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbOdaNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 316);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // vekilId
            // 
            this.vekilId.AutoSize = true;
            this.vekilId.Location = new System.Drawing.Point(653, 230);
            this.vekilId.Name = "vekilId";
            this.vekilId.Size = new System.Drawing.Size(15, 13);
            this.vekilId.TabIndex = 59;
            this.vekilId.Text = "ıd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 58;
            this.label1.Text = "İl";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(508, 250);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 50);
            this.btnKaydet.TabIndex = 57;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbGenelMerkezGorev
            // 
            this.cbGenelMerkezGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGenelMerkezGorev.FormattingEnabled = true;
            this.cbGenelMerkezGorev.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbGenelMerkezGorev.Location = new System.Drawing.Point(167, 273);
            this.cbGenelMerkezGorev.Name = "cbGenelMerkezGorev";
            this.cbGenelMerkezGorev.Size = new System.Drawing.Size(203, 26);
            this.cbGenelMerkezGorev.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(53, 270);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 36);
            this.label19.TabIndex = 56;
            this.label19.Text = "Genel Merkez\r\nGörev";
            // 
            // cbMeslek
            // 
            this.cbMeslek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMeslek.FormattingEnabled = true;
            this.cbMeslek.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbMeslek.Location = new System.Drawing.Point(466, 67);
            this.cbMeslek.Name = "cbMeslek";
            this.cbMeslek.Size = new System.Drawing.Size(203, 26);
            this.cbMeslek.TabIndex = 53;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.Location = new System.Drawing.Point(353, 73);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 18);
            this.label18.TabIndex = 54;
            this.label18.Text = "Meslek";
            // 
            // cbMeclisGorev
            // 
            this.cbMeclisGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMeclisGorev.FormattingEnabled = true;
            this.cbMeclisGorev.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbMeclisGorev.Location = new System.Drawing.Point(167, 241);
            this.cbMeclisGorev.Name = "cbMeclisGorev";
            this.cbMeclisGorev.Size = new System.Drawing.Size(203, 26);
            this.cbMeclisGorev.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(53, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 18);
            this.label13.TabIndex = 44;
            this.label13.Text = "Meclis Görev";
            // 
            // cbDostlukGrup
            // 
            this.cbDostlukGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDostlukGrup.FormattingEnabled = true;
            this.cbDostlukGrup.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbDostlukGrup.Location = new System.Drawing.Point(465, 100);
            this.cbDostlukGrup.Name = "cbDostlukGrup";
            this.cbDostlukGrup.Size = new System.Drawing.Size(203, 26);
            this.cbDostlukGrup.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(351, 100);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "Dostluk Grup";
            // 
            // cbDonem
            // 
            this.cbDonem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDonem.FormattingEnabled = true;
            this.cbDonem.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbDonem.Location = new System.Drawing.Point(466, 35);
            this.cbDonem.Name = "cbDonem";
            this.cbDonem.Size = new System.Drawing.Size(203, 26);
            this.cbDonem.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(352, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 38;
            this.label6.Text = "Dönem";
            // 
            // cbPartiGrup
            // 
            this.cbPartiGrup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPartiGrup.FormattingEnabled = true;
            this.cbPartiGrup.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbPartiGrup.Location = new System.Drawing.Point(131, 140);
            this.cbPartiGrup.Name = "cbPartiGrup";
            this.cbPartiGrup.Size = new System.Drawing.Size(203, 26);
            this.cbPartiGrup.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(5, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "Parti Grup";
            // 
            // cbParti
            // 
            this.cbParti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbParti.FormattingEnabled = true;
            this.cbParti.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbParti.Location = new System.Drawing.Point(131, 108);
            this.cbParti.Name = "cbParti";
            this.cbParti.Size = new System.Drawing.Size(203, 26);
            this.cbParti.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "Parti";
            // 
            // cbIl
            // 
            this.cbIl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbIl.FormattingEnabled = true;
            this.cbIl.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbIl.Location = new System.Drawing.Point(131, 76);
            this.cbIl.Name = "cbIl";
            this.cbIl.Size = new System.Drawing.Size(203, 26);
            this.cbIl.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(9, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "İl";
            // 
            // cbKomisyonDurum
            // 
            this.cbKomisyonDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbKomisyonDurum.FormattingEnabled = true;
            this.cbKomisyonDurum.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbKomisyonDurum.Location = new System.Drawing.Point(167, 209);
            this.cbKomisyonDurum.Name = "cbKomisyonDurum";
            this.cbKomisyonDurum.Size = new System.Drawing.Size(203, 26);
            this.cbKomisyonDurum.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Komisyon Durum";
            // 
            // cbOdaNo
            // 
            this.cbOdaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbOdaNo.FormattingEnabled = true;
            this.cbOdaNo.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbOdaNo.Location = new System.Drawing.Point(131, 36);
            this.cbOdaNo.Name = "cbOdaNo";
            this.cbOdaNo.Size = new System.Drawing.Size(203, 26);
            this.cbOdaNo.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 22;
            this.label2.Text = "Oda No";
            // 
            // FrmVekilDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 335);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVekilDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVekilDetay";
            this.Load += new System.EventHandler(this.FrmVekilDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMeclisGorev;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbDostlukGrup;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDonem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPartiGrup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbParti;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbIl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbKomisyonDurum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbOdaNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGenelMerkezGorev;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbMeslek;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label vekilId;
    }
}