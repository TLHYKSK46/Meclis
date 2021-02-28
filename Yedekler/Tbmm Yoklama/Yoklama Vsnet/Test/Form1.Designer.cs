namespace Test
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
            this.txtOturum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fileD = new System.Windows.Forms.OpenFileDialog();
            this.dtOturum = new System.Windows.Forms.DateTimePicker();
            this.BtnListele = new System.Windows.Forms.Button();
            this.cmbOturum2 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDosya = new System.Windows.Forms.TextBox();
            this.BtnSec = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btnMazeretKaydet = new System.Windows.Forms.Button();
            this.btnMazeretSec = new System.Windows.Forms.Button();
            this.txtMazeret = new System.Windows.Forms.TextBox();
            this.fdMazeret = new System.Windows.Forms.OpenFileDialog();
            this.btnIndir = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.cmbDurum = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSonuc = new System.Windows.Forms.Button();
            this.cmbOturum1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOturum = new System.Windows.Forms.ComboBox();
            this.BtnExcel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOturum
            // 
            this.txtOturum.Location = new System.Drawing.Point(89, 77);
            this.txtOturum.Name = "txtOturum";
            this.txtOturum.Size = new System.Drawing.Size(263, 20);
            this.txtOturum.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Oturum Adı";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(579, 75);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(75, 23);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 312);
            this.dataGridView1.TabIndex = 16;
            // 
            // fileD
            // 
            this.fileD.FileName = "openFileDialog1";
            // 
            // dtOturum
            // 
            this.dtOturum.Location = new System.Drawing.Point(358, 77);
            this.dtOturum.Name = "dtOturum";
            this.dtOturum.Size = new System.Drawing.Size(200, 20);
            this.dtOturum.TabIndex = 18;
            this.dtOturum.ValueChanged += new System.EventHandler(this.dtOturum_ValueChanged);
            // 
            // BtnListele
            // 
            this.BtnListele.Location = new System.Drawing.Point(501, 459);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(75, 23);
            this.BtnListele.TabIndex = 22;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // cmbOturum2
            // 
            this.cmbOturum2.FormattingEnabled = true;
            this.cmbOturum2.Location = new System.Drawing.Point(278, 459);
            this.cmbOturum2.Name = "cmbOturum2";
            this.cmbOturum2.Size = new System.Drawing.Size(217, 21);
            this.cmbOturum2.TabIndex = 20;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 486);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(645, 312);
            this.dataGridView2.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dosya Seçiniz";
            // 
            // txtDosya
            // 
            this.txtDosya.Location = new System.Drawing.Point(89, 48);
            this.txtDosya.Name = "txtDosya";
            this.txtDosya.Size = new System.Drawing.Size(484, 20);
            this.txtDosya.TabIndex = 13;
            // 
            // BtnSec
            // 
            this.BtnSec.Location = new System.Drawing.Point(579, 45);
            this.BtnSec.Name = "BtnSec";
            this.BtnSec.Size = new System.Drawing.Size(75, 23);
            this.BtnSec.TabIndex = 14;
            this.BtnSec.Text = "Seç";
            this.BtnSec.UseVisualStyleBackColor = true;
            this.BtnSec.Click += new System.EventHandler(this.BtnSec_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(660, 104);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(645, 312);
            this.dataGridView3.TabIndex = 29;
            // 
            // btnMazeretKaydet
            // 
            this.btnMazeretKaydet.Location = new System.Drawing.Point(1193, 70);
            this.btnMazeretKaydet.Name = "btnMazeretKaydet";
            this.btnMazeretKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnMazeretKaydet.TabIndex = 28;
            this.btnMazeretKaydet.Text = "Kaydet";
            this.btnMazeretKaydet.UseVisualStyleBackColor = true;
            this.btnMazeretKaydet.Click += new System.EventHandler(this.btnMazeretKaydet_Click);
            // 
            // btnMazeretSec
            // 
            this.btnMazeretSec.Location = new System.Drawing.Point(1112, 70);
            this.btnMazeretSec.Name = "btnMazeretSec";
            this.btnMazeretSec.Size = new System.Drawing.Size(75, 23);
            this.btnMazeretSec.TabIndex = 27;
            this.btnMazeretSec.Text = "Seç";
            this.btnMazeretSec.UseVisualStyleBackColor = true;
            this.btnMazeretSec.Click += new System.EventHandler(this.btnMazeretSec_Click);
            // 
            // txtMazeret
            // 
            this.txtMazeret.Location = new System.Drawing.Point(660, 73);
            this.txtMazeret.Name = "txtMazeret";
            this.txtMazeret.Size = new System.Drawing.Size(446, 20);
            this.txtMazeret.TabIndex = 26;
            // 
            // fdMazeret
            // 
            this.fdMazeret.FileName = "openFileDialog1";
            // 
            // btnIndir
            // 
            this.btnIndir.Location = new System.Drawing.Point(582, 459);
            this.btnIndir.Name = "btnIndir";
            this.btnIndir.Size = new System.Drawing.Size(75, 23);
            this.btnIndir.TabIndex = 30;
            this.btnIndir.Text = "Excel";
            this.btnIndir.UseVisualStyleBackColor = true;
            this.btnIndir.Click += new System.EventHandler(this.btnIndir_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(663, 486);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(645, 312);
            this.dataGridView4.TabIndex = 31;
            // 
            // cmbDurum
            // 
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Items.AddRange(new object[] {
            "Katılanlar",
            "Katılmayanlar",
            "Mazeretli"});
            this.cmbDurum.Location = new System.Drawing.Point(929, 459);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(162, 21);
            this.cmbDurum.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(885, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Durum";
            // 
            // btnSonuc
            // 
            this.btnSonuc.Location = new System.Drawing.Point(1115, 457);
            this.btnSonuc.Name = "btnSonuc";
            this.btnSonuc.Size = new System.Drawing.Size(75, 23);
            this.btnSonuc.TabIndex = 34;
            this.btnSonuc.Text = "Listele";
            this.btnSonuc.UseVisualStyleBackColor = true;
            this.btnSonuc.Click += new System.EventHandler(this.btnSonuc_Click);
            // 
            // cmbOturum1
            // 
            this.cmbOturum1.FormattingEnabled = true;
            this.cmbOturum1.Location = new System.Drawing.Point(59, 459);
            this.cmbOturum1.Name = "cmbOturum1";
            this.cmbOturum1.Size = new System.Drawing.Size(213, 21);
            this.cmbOturum1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Oturum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(666, 462);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Oturum";
            // 
            // cmbOturum
            // 
            this.cmbOturum.FormattingEnabled = true;
            this.cmbOturum.Location = new System.Drawing.Point(713, 459);
            this.cmbOturum.Name = "cmbOturum";
            this.cmbOturum.Size = new System.Drawing.Size(173, 21);
            this.cmbOturum.TabIndex = 35;
            // 
            // BtnExcel
            // 
            this.BtnExcel.Location = new System.Drawing.Point(1196, 457);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(75, 23);
            this.BtnExcel.TabIndex = 37;
            this.BtnExcel.Text = "Excel";
            this.BtnExcel.UseVisualStyleBackColor = true;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(188, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(298, 25);
            this.label6.TabIndex = 38;
            this.label6.Text = "YOKLAMA AKTARIM İŞLEMİ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(808, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 25);
            this.label7.TabIndex = 39;
            this.label7.Text = "MAZERET AKTARIM İŞLEMİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(11, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(627, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "SEÇİLİ İKİ OTURUMUN İLKİNDE OLMAYIP İKİNCİSİNDE OLANLAR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(804, 432);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(374, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "YOKLAMA SONUÇ (VEKİL LİSTESİ)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 578);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnExcel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbOturum);
            this.Controls.Add(this.btnSonuc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.btnIndir);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.btnMazeretKaydet);
            this.Controls.Add(this.btnMazeretSec);
            this.Controls.Add(this.txtMazeret);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOturum2);
            this.Controls.Add(this.cmbOturum1);
            this.Controls.Add(this.dtOturum);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnSec);
            this.Controls.Add(this.txtDosya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOturum);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOturum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog fileD;
        private System.Windows.Forms.DateTimePicker dtOturum;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.ComboBox cmbOturum2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDosya;
        private System.Windows.Forms.Button BtnSec;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button btnMazeretKaydet;
        private System.Windows.Forms.Button btnMazeretSec;
        private System.Windows.Forms.TextBox txtMazeret;
        private System.Windows.Forms.OpenFileDialog fdMazeret;
        private System.Windows.Forms.Button btnIndir;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.ComboBox cmbDurum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSonuc;
        private System.Windows.Forms.ComboBox cmbOturum1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbOturum;
        private System.Windows.Forms.Button BtnExcel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

