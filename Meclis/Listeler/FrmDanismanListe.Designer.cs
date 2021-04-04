
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanismanListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDanismanListe
            // 
            this.dgDanismanListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanismanListe.Location = new System.Drawing.Point(12, 138);
            this.dgDanismanListe.Name = "dgDanismanListe";
            this.dgDanismanListe.Size = new System.Drawing.Size(776, 286);
            this.dgDanismanListe.TabIndex = 0;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(579, 112);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(209, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(363, 74);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(131, 20);
            this.maskedTextBox1.TabIndex = 2;
            // 
            // FrmDanismanListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.dgDanismanListe);
            this.Name = "FrmDanismanListe";
            this.Text = "DanismanListe";
            this.Load += new System.EventHandler(this.FrmDanismanListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDanismanListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDanismanListe;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}