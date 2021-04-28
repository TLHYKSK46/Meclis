
namespace Meclis.Listeler
{
    partial class FrmDilListe
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
            this.txtAra = new System.Windows.Forms.TextBox();
            this.dgDilListe = new System.Windows.Forms.DataGridView();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDilListe)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(403, 48);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(419, 26);
            this.txtAra.TabIndex = 0;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // dgDilListe
            // 
            this.dgDilListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDilListe.Location = new System.Drawing.Point(3, 136);
            this.dgDilListe.Name = "dgDilListe";
            this.dgDilListe.Size = new System.Drawing.Size(1029, 352);
            this.dgDilListe.TabIndex = 1;
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.Location = new System.Drawing.Point(3, 509);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(1029, 46);
            this.btnExcelAktar.TabIndex = 2;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = true;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(828, 41);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(204, 43);
            this.btnAra.TabIndex = 6;
            this.btnAra.Text = "Filtrele";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbFiltre
            // 
            this.cmbFiltre.FormattingEnabled = true;
            this.cmbFiltre.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cmbFiltre.Location = new System.Drawing.Point(194, 52);
            this.cmbFiltre.Name = "cmbFiltre";
            this.cmbFiltre.Size = new System.Drawing.Size(203, 21);
            this.cmbFiltre.TabIndex = 5;
            // 
            // FrmDilListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 557);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbFiltre);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.dgDilListe);
            this.Controls.Add(this.txtAra);
            this.Name = "FrmDilListe";
            this.Text = "DilListe";
            this.Load += new System.EventHandler(this.FrmDilListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDilListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.DataGridView dgDilListe;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbFiltre;
    }
}