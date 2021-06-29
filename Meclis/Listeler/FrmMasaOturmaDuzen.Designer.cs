
namespace Meclis.Listeler
{
    partial class FrmMasaOturmaDuzen
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chkListVekil = new System.Windows.Forms.CheckedListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.listMasaOturanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chkListVekil
            // 
            this.chkListVekil.FormattingEnabled = true;
            this.chkListVekil.Location = new System.Drawing.Point(0, 64);
            this.chkListVekil.Name = "chkListVekil";
            this.chkListVekil.Size = new System.Drawing.Size(270, 529);
            this.chkListVekil.TabIndex = 0;
            this.chkListVekil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkListVekil_MouseClick);
            this.chkListVekil.SelectedIndexChanged += new System.EventHandler(this.chkListVekil_SelectedIndexChanged);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(17, 20);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(136, 57);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Seçilenleri Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // listMasaOturanlar
            // 
            this.listMasaOturanlar.FormattingEnabled = true;
            this.listMasaOturanlar.Location = new System.Drawing.Point(17, 83);
            this.listMasaOturanlar.Name = "listMasaOturanlar";
            this.listMasaOturanlar.Size = new System.Drawing.Size(481, 511);
            this.listMasaOturanlar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(12, 12);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(237, 20);
            this.dtTarih.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chkListVekil);
            this.splitContainer1.Panel1.Controls.Add(this.dtTarih);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnKaydet);
            this.splitContainer1.Panel2.Controls.Add(this.btnAktar);
            this.splitContainer1.Panel2.Controls.Add(this.listMasaOturanlar);
            this.splitContainer1.Size = new System.Drawing.Size(779, 598);
            this.splitContainer1.SplitterDistance = 271;
            this.splitContainer1.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(159, 20);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 57);
            this.btnKaydet.TabIndex = 4;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // FrmMasaOturmaDuzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 598);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmMasaOturmaDuzen";
            this.Text = "FrmMasaOturmaDuzen";
            this.Load += new System.EventHandler(this.FrmMasaOturmaDuzen_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox chkListVekil;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox listMasaOturanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnKaydet;
    }
}