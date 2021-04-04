
namespace Meclis.Listeler
{
    partial class FrmMeslekListe
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
            this.txtListeAra = new System.Windows.Forms.TextBox();
            this.dgMeslekList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgMeslekList)).BeginInit();
            this.SuspendLayout();
            // 
            // txtListeAra
            // 
            this.txtListeAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtListeAra.Location = new System.Drawing.Point(576, 52);
            this.txtListeAra.Name = "txtListeAra";
            this.txtListeAra.Size = new System.Drawing.Size(212, 26);
            this.txtListeAra.TabIndex = 0;
            this.txtListeAra.TextChanged += new System.EventHandler(this.txtListeAra_TextChanged);
            // 
            // dgMeslekList
            // 
            this.dgMeslekList.AllowUserToOrderColumns = true;
            this.dgMeslekList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMeslekList.Location = new System.Drawing.Point(12, 84);
            this.dgMeslekList.Name = "dgMeslekList";
            this.dgMeslekList.Size = new System.Drawing.Size(776, 354);
            this.dgMeslekList.TabIndex = 1;
            this.dgMeslekList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMeslekList_CellContentClick);
            // 
            // FrmMeslekListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgMeslekList);
            this.Controls.Add(this.txtListeAra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMeslekListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeslekListe";
            this.Load += new System.EventHandler(this.MeslekListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMeslekList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtListeAra;
        private System.Windows.Forms.DataGridView dgMeslekList;
    }
}