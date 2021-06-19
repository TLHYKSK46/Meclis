
namespace Meclis.Yoklama
{
    partial class FrmYoklama
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOturumVekil = new System.Windows.Forms.ComboBox();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDurumVekil = new System.Windows.Forms.ComboBox();
            this.dgGridVekilList = new System.Windows.Forms.DataGridView();
            this.btnIndir = new System.Windows.Forms.Button();
            this.fdMazeret = new System.Windows.Forms.OpenFileDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.dtGridMazeret = new System.Windows.Forms.DataGridView();
            this.btnMazeretKaydet = new System.Windows.Forms.Button();
            this.btnMazeretSec = new System.Windows.Forms.Button();
            this.txtMazeret = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.BtnListele = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOturum2 = new System.Windows.Forms.ComboBox();
            this.cmbOturum1 = new System.Windows.Forms.ComboBox();
            this.dtOturum = new System.Windows.Forms.DateTimePicker();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileD = new System.Windows.Forms.OpenFileDialog();
            this.dtGridYoklama = new System.Windows.Forms.DataGridView();
            this.BtnYoklamaKaydet = new System.Windows.Forms.Button();
            this.BtnYoklamaSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOturum = new System.Windows.Forms.TextBox();
            this.btnSistemdenIsle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgGridVekilList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMazeret)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridYoklama)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(913, 434);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 25);
            this.label9.TabIndex = 70;
            this.label9.Text = "VEKİL LİSTESİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(811, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "MAZERET AKTARIM İŞLEMİ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(191, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 25);
            this.label6.TabIndex = 67;
            this.label6.Text = "YOKLAMA AKTARIM İŞLEMİ";
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(1199, 459);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 66;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(669, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Oturum";
            // 
            // cbOturumVekil
            // 
            this.cbOturumVekil.FormattingEnabled = true;
            this.cbOturumVekil.Location = new System.Drawing.Point(716, 461);
            this.cbOturumVekil.Name = "cbOturumVekil";
            this.cbOturumVekil.Size = new System.Drawing.Size(173, 21);
            this.cbOturumVekil.TabIndex = 64;
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(1118, 459);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 63;
            this.btnSonuc.Text = "Listele";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(888, 464);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Durum";
            // 
            // cbDurumVekil
            // 
            this.cbDurumVekil.FormattingEnabled = true;
            this.cbDurumVekil.Items.AddRange(new object[] {
            "Katılanlar",
            "Katılmayanlar",
            "Mazeretli"});
            this.cbDurumVekil.Location = new System.Drawing.Point(932, 461);
            this.cbDurumVekil.Name = "cbDurumVekil";
            this.cbDurumVekil.Size = new System.Drawing.Size(162, 21);
            this.cbDurumVekil.TabIndex = 61;
            // 
            // dgGridVekilList
            // 
            this.dgGridVekilList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGridVekilList.Location = new System.Drawing.Point(666, 488);
            this.dgGridVekilList.Name = "dgGridVekilList";
            this.dgGridVekilList.Size = new System.Drawing.Size(749, 312);
            this.dgGridVekilList.TabIndex = 60;
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(585, 461);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(75, 23);
            this.btnIndir.TabIndex = 59;
            this.btnIndir.Text = "Excel";
            this.btnIndir.UseVisualStyleBackColor = true;
            // 
            // fdMazeret
            // 
            this.fdMazeret.FileName = "openFileDialog1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 434);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(627, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "SEÇİLİ İKİ OTURUMUN İLKİNDE OLMAYIP İKİNCİSİNDE OLANLAR";
            // 
            // dtGridMazeret
            // 
            this.dtGridMazeret.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridMazeret.Location = new System.Drawing.Point(663, 106);
            this.dtGridMazeret.Name = "dtGridMazeret";
            this.dtGridMazeret.Size = new System.Drawing.Size(752, 312);
            this.dtGridMazeret.TabIndex = 58;
            // 
            // btnMazeretKaydet
            // 
            this.btnMazeretKaydet.Location = new System.Drawing.Point(1196, 66);
            this.btnMazeretKaydet.Name = "btnMazeretKaydet";
            this.btnMazeretKaydet.Size = new System.Drawing.Size(75, 29);
            this.btnMazeretKaydet.TabIndex = 57;
            this.btnMazeretKaydet.Text = "Kaydet";
            this.btnMazeretKaydet.UseVisualStyleBackColor = true;
            this.btnMazeretKaydet.Click += new System.EventHandler(this.btnMazeretKaydet_Click);
            // 
            // btnMazeretSec
            // 
            this.btnMazeretSec.Location = new System.Drawing.Point(1196, 32);
            this.btnMazeretSec.Name = "btnMazeretSec";
            this.btnMazeretSec.Size = new System.Drawing.Size(75, 30);
            this.btnMazeretSec.TabIndex = 56;
            this.btnMazeretSec.Text = "Excel Yükle";
            this.btnMazeretSec.UseVisualStyleBackColor = true;
            this.btnMazeretSec.Click += new System.EventHandler(this.btnMazeretSec_Click);
            // 
            // txtMazeret
            // 
            this.txtMazeret.Location = new System.Drawing.Point(663, 75);
            this.txtMazeret.Name = "txtMazeret";
            this.txtMazeret.Size = new System.Drawing.Size(446, 20);
            this.txtMazeret.TabIndex = 55;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 488);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 312);
            this.dataGridView2.TabIndex = 54;
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(504, 461);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(75, 23);
            this.BtnListele.TabIndex = 53;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Oturum";
            // 
            // cmbOturum2
            // 
            this.cmbOturum2.FormattingEnabled = true;
            this.cmbOturum2.Location = new System.Drawing.Point(281, 461);
            this.cmbOturum2.Name = "cmbOturum2";
            this.cmbOturum2.Size = new System.Drawing.Size(217, 21);
            this.cmbOturum2.TabIndex = 51;
            // 
            // cmbOturum1
            // 
            this.cmbOturum1.FormattingEnabled = true;
            this.cmbOturum1.Location = new System.Drawing.Point(62, 461);
            this.cmbOturum1.Name = "cmbOturum1";
            this.cmbOturum1.Size = new System.Drawing.Size(213, 21);
            this.cmbOturum1.TabIndex = 50;
            // 
            // dtOturum
            // 
            this.dtOturum.Location = new System.Drawing.Point(361, 79);
            this.dtOturum.Name = "dtOturum";
            this.dtOturum.Size = new System.Drawing.Size(200, 20);
            this.dtOturum.TabIndex = 49;
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(92, 50);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(484, 20);
            this.txtDosya.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Dosya Seçiniz";
            // 
            // fileD
            // 
            this.fileD.FileName = "openFileDialog1";
            // 
            // dtGridYoklama
            // 
            this.dtGridYoklama.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridYoklama.Location = new System.Drawing.Point(12, 106);
            this.dtGridYoklama.Name = "dtGridYoklama";
            this.dtGridYoklama.Size = new System.Drawing.Size(645, 312);
            this.dtGridYoklama.TabIndex = 48;
            // 
            // BtnYoklamaKaydet
            // 
            this.BtnYoklamaKaydet.Location = new System.Drawing.Point(582, 77);
            this.BtnYoklamaKaydet.Name = "BtnYoklamaKaydet";
            this.BtnYoklamaKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnYoklamaKaydet.TabIndex = 47;
            this.BtnYoklamaKaydet.Text = "Kaydet";
            this.BtnYoklamaKaydet.UseVisualStyleBackColor = true;
            this.BtnYoklamaKaydet.Click += new System.EventHandler(this.BtnYoklamaKaydet_Click);
            // 
            // BtnYoklamaSec
            // 
            this.BtnYoklamaSec.Location = new System.Drawing.Point(582, 47);
            this.BtnYoklamaSec.Name = "BtnYoklamaSec";
            this.BtnYoklamaSec.Size = new System.Drawing.Size(75, 23);
            this.BtnYoklamaSec.TabIndex = 46;
            this.BtnYoklamaSec.Text = "Excel Yükle";
            this.BtnYoklamaSec.UseVisualStyleBackColor = true;
            this.BtnYoklamaSec.Click += new System.EventHandler(this.BtnYoklamaSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Oturum Adı";
            // 
            // txtOturum
            // 
            this.txtOturum.Location = new System.Drawing.Point(92, 79);
            this.txtOturum.Name = "txtOturum";
            this.txtOturum.Size = new System.Drawing.Size(263, 20);
            this.txtOturum.TabIndex = 42;
            // 
            // btnSistemdenIsle
            // 
            this.btnSistemdenIsle.Location = new System.Drawing.Point(1118, 31);
            this.btnSistemdenIsle.Name = "btnSistemdenIsle";
            this.btnSistemdenIsle.Size = new System.Drawing.Size(75, 64);
            this.btnSistemdenIsle.TabIndex = 71;
            this.btnSistemdenIsle.Text = "Sistemden İşle";
            this.btnSistemdenIsle.UseVisualStyleBackColor = true;
            this.btnSistemdenIsle.Click += new System.EventHandler(this.btnSistemdenIsle_Click);
            // 
            // FrmYoklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 815);
            this.Controls.Add(this.btnSistemdenIsle);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbOturumVekil);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDurumVekil);
            this.Controls.Add(this.dgGridVekilList);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtGridMazeret);
            this.Controls.Add(this.btnMazeretKaydet);
            this.Controls.Add(this.btnMazeretSec);
            this.Controls.Add(this.txtMazeret);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOturum2);
            this.Controls.Add(this.cmbOturum1);
            this.Controls.Add(this.dtOturum);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtGridYoklama);
            this.Controls.Add(this.BtnYoklamaKaydet);
            this.Controls.Add(this.BtnYoklamaSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOturum);
            this.MaximizeBox = false;
            this.Name = "FrmYoklama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoklamaEski";
            this.Load += new System.EventHandler(this.FrmYoklamaEski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGridVekilList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridMazeret)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridYoklama)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOturumVekil;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDurumVekil;
        private System.Windows.Forms.DataGridView dgGridVekilList;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.OpenFileDialog fdMazeret;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtGridMazeret;
        private System.Windows.Forms.Button btnMazeretKaydet;
        private System.Windows.Forms.Button btnMazeretSec;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOturum2;
        private System.Windows.Forms.ComboBox cmbOturum1;
        private System.Windows.Forms.DateTimePicker dtOturum;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog fileD;
        private System.Windows.Forms.DataGridView dtGridYoklama;
        private System.Windows.Forms.Button BtnYoklamaKaydet;
        private System.Windows.Forms.Button BtnYoklamaSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOturum;
        private System.Windows.Forms.Button btnSistemdenIsle;
        public System.Windows.Forms.TextBox txtMazeret;
    }
}