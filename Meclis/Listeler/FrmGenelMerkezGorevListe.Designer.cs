
namespace Meclis.Listeler
{
    partial class FrmGenelMerkezGorevListe
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
            this.dgGenelMerkezListe = new System.Windows.Forms.DataGridView();
            this.txtAra = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgGenelMerkezListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgGenelMerkezListe
            // 
            this.dgGenelMerkezListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGenelMerkezListe.Location = new System.Drawing.Point(12, 99);
            this.dgGenelMerkezListe.Name = "dgGenelMerkezListe";
            this.dgGenelMerkezListe.Size = new System.Drawing.Size(776, 339);
            this.dgGenelMerkezListe.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(596, 67);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(192, 26);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // FrmGenelMerkezGorevListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgGenelMerkezListe);
            this.Name = "FrmGenelMerkezGorevListe";
            this.Text = "GenelMerkezGorevListe";
            this.Load += new System.EventHandler(this.FrmGenelMerkezGorevListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgGenelMerkezListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgGenelMerkezListe;
        private System.Windows.Forms.TextBox txtAra;
    }
}