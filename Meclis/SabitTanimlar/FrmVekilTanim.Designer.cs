
namespace Meclis.SabitTanimlar
{
    partial class FrmVekilTanim
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
            this.txtTcKimlikNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKurumsalTelNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKisiselTelNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKurumsalMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKisiselMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOzGecmis = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAktif = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFotoYukle = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.cbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDogumYeri = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(822, 379);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(125, 48);
            this.btnKaydet.TabIndex = 11;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtTcKimlikNo
            // 
            this.txtTcKimlikNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcKimlikNo.Location = new System.Drawing.Point(517, 25);
            this.txtTcKimlikNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtTcKimlikNo.Name = "txtTcKimlikNo";
            this.txtTcKimlikNo.Size = new System.Drawing.Size(287, 27);
            this.txtTcKimlikNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "T.C. Kimlik No:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(517, 56);
            this.txtAd.Margin = new System.Windows.Forms.Padding(2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(287, 27);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(358, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adı:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(517, 87);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(287, 27);
            this.txtSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(358, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Soyadı:";
            // 
            // txtKurumsalTelNo
            // 
            this.txtKurumsalTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurumsalTelNo.Location = new System.Drawing.Point(517, 151);
            this.txtKurumsalTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKurumsalTelNo.Name = "txtKurumsalTelNo";
            this.txtKurumsalTelNo.Size = new System.Drawing.Size(287, 27);
            this.txtKurumsalTelNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(358, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kurumsal Tel. No:";
            // 
            // txtKisiselTelNo
            // 
            this.txtKisiselTelNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiselTelNo.Location = new System.Drawing.Point(517, 182);
            this.txtKisiselTelNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtKisiselTelNo.Name = "txtKisiselTelNo";
            this.txtKisiselTelNo.Size = new System.Drawing.Size(287, 27);
            this.txtKisiselTelNo.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(358, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Kişisel Tel. No:";
            // 
            // txtKurumsalMail
            // 
            this.txtKurumsalMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKurumsalMail.Location = new System.Drawing.Point(517, 213);
            this.txtKurumsalMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtKurumsalMail.Name = "txtKurumsalMail";
            this.txtKurumsalMail.Size = new System.Drawing.Size(287, 27);
            this.txtKurumsalMail.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(358, 213);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Kurumsal Mail:";
            // 
            // txtKisiselMail
            // 
            this.txtKisiselMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKisiselMail.Location = new System.Drawing.Point(517, 247);
            this.txtKisiselMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtKisiselMail.Name = "txtKisiselMail";
            this.txtKisiselMail.Size = new System.Drawing.Size(287, 27);
            this.txtKisiselMail.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(358, 247);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kişisel Mail:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(848, 39);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(357, 130);
            this.txtAciklama.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(844, 17);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Açıklama:";
            // 
            // txtOzGecmis
            // 
            this.txtOzGecmis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOzGecmis.Location = new System.Drawing.Point(848, 202);
            this.txtOzGecmis.Margin = new System.Windows.Forms.Padding(2);
            this.txtOzGecmis.Multiline = true;
            this.txtOzGecmis.Name = "txtOzGecmis";
            this.txtOzGecmis.Size = new System.Drawing.Size(357, 161);
            this.txtOzGecmis.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(844, 180);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Öz Geçmiş:";
            // 
            // chkAktif
            // 
            this.chkAktif.AutoSize = true;
            this.chkAktif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkAktif.Location = new System.Drawing.Point(517, 338);
            this.chkAktif.Margin = new System.Windows.Forms.Padding(2);
            this.chkAktif.Name = "chkAktif";
            this.chkAktif.Size = new System.Drawing.Size(61, 24);
            this.chkAktif.TabIndex = 8;
            this.chkAktif.Text = "Aktif";
            this.chkAktif.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFotoYukle);
            this.groupBox1.Controls.Add(this.pbFoto);
            this.groupBox1.Controls.Add(this.cbCinsiyet);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbDogumYeri);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtDogumTarihi);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTcKimlikNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.chkAktif);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOzGecmis);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.txtKurumsalTelNo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtKisiselMail);
            this.groupBox1.Controls.Add(this.txtKisiselTelNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKurumsalMail);
            this.groupBox1.Location = new System.Drawing.Point(1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 446);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // btnFotoYukle
            // 
            this.btnFotoYukle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFotoYukle.Location = new System.Drawing.Point(30, 261);
            this.btnFotoYukle.Margin = new System.Windows.Forms.Padding(2);
            this.btnFotoYukle.Name = "btnFotoYukle";
            this.btnFotoYukle.Size = new System.Drawing.Size(194, 44);
            this.btnFotoYukle.TabIndex = 67;
            this.btnFotoYukle.Text = "Yükle";
            this.btnFotoYukle.UseVisualStyleBackColor = true;
            this.btnFotoYukle.Click += new System.EventHandler(this.btnFotoYukle_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Image = global::Meclis.Properties.Resources.user;
            this.pbFoto.Location = new System.Drawing.Point(30, 35);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(194, 221);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 66;
            this.pbFoto.TabStop = false;
            // 
            // cbCinsiyet
            // 
            this.cbCinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbCinsiyet.FormattingEnabled = true;
            this.cbCinsiyet.Location = new System.Drawing.Point(517, 119);
            this.cbCinsiyet.Name = "cbCinsiyet";
            this.cbCinsiyet.Size = new System.Drawing.Size(287, 28);
            this.cbCinsiyet.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(358, 118);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 64;
            this.label10.Text = "Cinsiyet:";
            // 
            // cbDogumYeri
            // 
            this.cbDogumYeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbDogumYeri.FormattingEnabled = true;
            this.cbDogumYeri.Location = new System.Drawing.Point(517, 311);
            this.cbDogumYeri.Name = "cbDogumYeri";
            this.cbDogumYeri.Size = new System.Drawing.Size(287, 28);
            this.cbDogumYeri.TabIndex = 62;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(358, 314);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 61;
            this.label13.Text = "Doğum Yeri:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(358, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 60;
            this.label12.Text = "Doğum Tarihi:";
            // 
            // dtDogumTarihi
            // 
            this.dtDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDogumTarihi.Location = new System.Drawing.Point(517, 279);
            this.dtDogumTarihi.Name = "dtDogumTarihi";
            this.dtDogumTarihi.Size = new System.Drawing.Size(287, 26);
            this.dtDogumTarihi.TabIndex = 59;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1080, 379);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(125, 49);
            this.btnSil.TabIndex = 58;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(951, 379);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(125, 49);
            this.btnGuncelle.TabIndex = 57;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgListe
            // 
            this.dgListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListe.Location = new System.Drawing.Point(12, 497);
            this.dgListe.Name = "dgListe";
            this.dgListe.Size = new System.Drawing.Size(1220, 331);
            this.dgListe.TabIndex = 28;
            this.dgListe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgListe_CellClick);
            // 
            // txtAra
            // 
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(16, 464);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(340, 27);
            this.txtAra.TabIndex = 54;
            // 
            // FrmVekilTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 831);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgListe);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmVekilTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVekilTanim";
            this.Load += new System.EventHandler(this.FrmVekilTanim_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtTcKimlikNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKurumsalTelNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKisiselTelNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKurumsalMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKisiselMail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOzGecmis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAktif;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cbDogumYeri;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtDogumTarihi;
        private System.Windows.Forms.ComboBox cbCinsiyet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFotoYukle;
        private System.Windows.Forms.PictureBox pbFoto;
    }
}