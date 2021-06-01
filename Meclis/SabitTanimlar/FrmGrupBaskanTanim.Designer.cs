
namespace Meclis.SabitTanimlar
{
    partial class FrmGrupBaskanTanim
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgListeBaskan = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSil1 = new System.Windows.Forms.Button();
            this.btnGuncelle1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKaydet1 = new System.Windows.Forms.Button();
            this.cbVekilBaskan = new System.Windows.Forms.ComboBox();
            this.dgBaskanVekilListe = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbGrupBaskan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbVekilBaskanVekil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbVekilYonetim = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGrupBaskanYonetim = new System.Windows.Forms.ComboBox();
            this.btnSil3 = new System.Windows.Forms.Button();
            this.btnGuncelle3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydet3 = new System.Windows.Forms.Button();
            this.cbGrupBaskanYonetimVekil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeBaskan)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaskanVekilListe)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(7, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1060, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgListeBaskan);
            this.tabPage1.Controls.Add(this.txtAra);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1052, 530);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Grup Başkan Tanım";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgBaskanVekilListe);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1052, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Grup Başkan Vekil Tanım";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1052, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Grup Yönetim Kurulu Uye Tanım";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgListeBaskan
            // 
            this.dgListeBaskan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListeBaskan.Location = new System.Drawing.Point(21, 108);
            this.dgListeBaskan.Name = "dgListeBaskan";
            this.dgListeBaskan.Size = new System.Drawing.Size(615, 416);
            this.dgListeBaskan.TabIndex = 57;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(21, 60);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(334, 27);
            this.txtAra.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVekilBaskan);
            this.groupBox1.Controls.Add(this.btnSil1);
            this.groupBox1.Controls.Add(this.btnGuncelle1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnKaydet1);
            this.groupBox1.Location = new System.Drawing.Point(658, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 518);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnSil1
            // 
            this.btnSil1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil1.Location = new System.Drawing.Point(269, 166);
            this.btnSil1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil1.Name = "btnSil1";
            this.btnSil1.Size = new System.Drawing.Size(98, 49);
            this.btnSil1.TabIndex = 52;
            this.btnSil1.Text = "Sil";
            this.btnSil1.UseVisualStyleBackColor = true;
            this.btnSil1.Click += new System.EventHandler(this.btnSil1_Click);
            // 
            // btnGuncelle1
            // 
            this.btnGuncelle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle1.Location = new System.Drawing.Point(150, 166);
            this.btnGuncelle1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle1.Name = "btnGuncelle1";
            this.btnGuncelle1.Size = new System.Drawing.Size(115, 49);
            this.btnGuncelle1.TabIndex = 51;
            this.btnGuncelle1.Text = "Güncelle";
            this.btnGuncelle1.UseVisualStyleBackColor = true;
            this.btnGuncelle1.Click += new System.EventHandler(this.btnGuncelle1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vekil";
            // 
            // btnKaydet1
            // 
            this.btnKaydet1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet1.Location = new System.Drawing.Point(23, 166);
            this.btnKaydet1.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet1.Name = "btnKaydet1";
            this.btnKaydet1.Size = new System.Drawing.Size(123, 49);
            this.btnKaydet1.TabIndex = 2;
            this.btnKaydet1.Text = "Kaydet";
            this.btnKaydet1.UseVisualStyleBackColor = true;
            this.btnKaydet1.Click += new System.EventHandler(this.btnKaydet1_Click);
            // 
            // cbVekilBaskan
            // 
            this.cbVekilBaskan.FormattingEnabled = true;
            this.cbVekilBaskan.Location = new System.Drawing.Point(94, 60);
            this.cbVekilBaskan.Name = "cbVekilBaskan";
            this.cbVekilBaskan.Size = new System.Drawing.Size(273, 21);
            this.cbVekilBaskan.TabIndex = 53;
            // 
            // dgBaskanVekilListe
            // 
            this.dgBaskanVekilListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBaskanVekilListe.Location = new System.Drawing.Point(16, 108);
            this.dgBaskanVekilListe.Name = "dgBaskanVekilListe";
            this.dgBaskanVekilListe.Size = new System.Drawing.Size(615, 416);
            this.dgBaskanVekilListe.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(16, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 27);
            this.textBox1.TabIndex = 59;
            // 
            // btnSil2
            // 
            this.btnSil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil2.Location = new System.Drawing.Point(269, 166);
            this.btnSil2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(98, 49);
            this.btnSil2.TabIndex = 52;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = true;
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle2.Location = new System.Drawing.Point(150, 166);
            this.btnGuncelle2.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(115, 49);
            this.btnGuncelle2.TabIndex = 51;
            this.btnGuncelle2.Text = "Güncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet2.Location = new System.Drawing.Point(23, 166);
            this.btnKaydet2.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(123, 49);
            this.btnKaydet2.TabIndex = 2;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbVekilBaskanVekil);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbGrupBaskan);
            this.groupBox2.Controls.Add(this.btnSil2);
            this.groupBox2.Controls.Add(this.btnGuncelle2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnKaydet2);
            this.groupBox2.Location = new System.Drawing.Point(653, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 518);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cbGrupBaskan
            // 
            this.cbGrupBaskan.FormattingEnabled = true;
            this.cbGrupBaskan.Location = new System.Drawing.Point(122, 60);
            this.cbGrupBaskan.Name = "cbGrupBaskan";
            this.cbGrupBaskan.Size = new System.Drawing.Size(245, 21);
            this.cbGrupBaskan.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(5, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Grup Başkan ";
            // 
            // cbVekilBaskanVekil
            // 
            this.cbVekilBaskanVekil.FormattingEnabled = true;
            this.cbVekilBaskanVekil.Location = new System.Drawing.Point(122, 102);
            this.cbVekilBaskanVekil.Name = "cbVekilBaskanVekil";
            this.cbVekilBaskanVekil.Size = new System.Drawing.Size(245, 21);
            this.cbVekilBaskanVekil.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(5, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Vekil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(615, 416);
            this.dataGridView1.TabIndex = 63;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(16, 60);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(334, 27);
            this.textBox2.TabIndex = 62;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGrupBaskanYonetimVekil);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbVekilYonetim);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cbGrupBaskanYonetim);
            this.groupBox3.Controls.Add(this.btnSil3);
            this.groupBox3.Controls.Add(this.btnGuncelle3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnKaydet3);
            this.groupBox3.Location = new System.Drawing.Point(653, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 518);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cbVekilYonetim
            // 
            this.cbVekilYonetim.FormattingEnabled = true;
            this.cbVekilYonetim.Location = new System.Drawing.Point(122, 87);
            this.cbVekilYonetim.Name = "cbVekilYonetim";
            this.cbVekilYonetim.Size = new System.Drawing.Size(245, 21);
            this.cbVekilYonetim.TabIndex = 55;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(5, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Vekil";
            // 
            // cbGrupBaskanYonetim
            // 
            this.cbGrupBaskanYonetim.FormattingEnabled = true;
            this.cbGrupBaskanYonetim.Location = new System.Drawing.Point(122, 60);
            this.cbGrupBaskanYonetim.Name = "cbGrupBaskanYonetim";
            this.cbGrupBaskanYonetim.Size = new System.Drawing.Size(245, 21);
            this.cbGrupBaskanYonetim.TabIndex = 53;
            // 
            // btnSil3
            // 
            this.btnSil3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil3.Location = new System.Drawing.Point(269, 166);
            this.btnSil3.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil3.Name = "btnSil3";
            this.btnSil3.Size = new System.Drawing.Size(98, 49);
            this.btnSil3.TabIndex = 52;
            this.btnSil3.Text = "Sil";
            this.btnSil3.UseVisualStyleBackColor = true;
            this.btnSil3.Click += new System.EventHandler(this.btnSil3_Click);
            // 
            // btnGuncelle3
            // 
            this.btnGuncelle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle3.Location = new System.Drawing.Point(150, 166);
            this.btnGuncelle3.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle3.Name = "btnGuncelle3";
            this.btnGuncelle3.Size = new System.Drawing.Size(115, 49);
            this.btnGuncelle3.TabIndex = 51;
            this.btnGuncelle3.Text = "Güncelle";
            this.btnGuncelle3.UseVisualStyleBackColor = true;
            this.btnGuncelle3.Click += new System.EventHandler(this.btnGuncelle3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(5, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Grup Başkan ";
            // 
            // btnKaydet3
            // 
            this.btnKaydet3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet3.Location = new System.Drawing.Point(23, 166);
            this.btnKaydet3.Margin = new System.Windows.Forms.Padding(2);
            this.btnKaydet3.Name = "btnKaydet3";
            this.btnKaydet3.Size = new System.Drawing.Size(123, 49);
            this.btnKaydet3.TabIndex = 2;
            this.btnKaydet3.Text = "Kaydet";
            this.btnKaydet3.UseVisualStyleBackColor = true;
            this.btnKaydet3.Click += new System.EventHandler(this.btnKaydet3_Click);
            // 
            // cbGrupBaskanYonetimVekil
            // 
            this.cbGrupBaskanYonetimVekil.FormattingEnabled = true;
            this.cbGrupBaskanYonetimVekil.Location = new System.Drawing.Point(122, 114);
            this.cbGrupBaskanYonetimVekil.Name = "cbGrupBaskanYonetimVekil";
            this.cbGrupBaskanYonetimVekil.Size = new System.Drawing.Size(245, 21);
            this.cbGrupBaskanYonetimVekil.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(5, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 40);
            this.label6.TabIndex = 56;
            this.label6.Text = "Grup Başkan\r\n Vekil";
            // 
            // FrmGrupBaskanTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmGrupBaskanTanim";
            this.Text = "FrmGrupBaskanTanim";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListeBaskan)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBaskanVekilListe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgListeBaskan;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVekilBaskan;
        private System.Windows.Forms.Button btnSil1;
        private System.Windows.Forms.Button btnGuncelle1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKaydet1;
        private System.Windows.Forms.DataGridView dgBaskanVekilListe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbVekilBaskanVekil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGrupBaskan;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbGrupBaskanYonetimVekil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbVekilYonetim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGrupBaskanYonetim;
        private System.Windows.Forms.Button btnSil3;
        private System.Windows.Forms.Button btnGuncelle3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydet3;
    }
}