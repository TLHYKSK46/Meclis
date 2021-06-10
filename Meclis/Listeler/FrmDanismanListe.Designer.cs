
namespace Meclis.Listeler
{
    partial class FrmDanismanListe
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
            this.dgDanismanListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanismanListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanismanListe
            // 
            this.dgDanismanListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanismanListe.Location = new System.Drawing.Point(0, 75);
            this.dgDanismanListe.Name = "dgDanismanListe";
            this.dgDanismanListe.Size = new System.Drawing.Size(1093, 434);
            this.dgDanismanListe.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(437, 38);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(409, 24);
            this.txtAra.TabIndex = 1;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcelAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExcelAktar.Location = new System.Drawing.Point(0, 515);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(1093, 43);
            this.btnExcelAktar.TabIndex = 2;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cmbFiltre.Location = new System.Drawing.Point(218, 37);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(203, 26);
            this.cmbFiltre.TabIndex = 3;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(852, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(204, 43);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Filtrele";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // FrmDanismanListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 558);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgDanismanListe);
            this.MaximizeBox = false;
            this.Name = "FrmDanismanListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanismanListe";
            this.Load += new System.EventHandler(this.FrmDanismanListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanismanListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanismanListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Button btnAra;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}