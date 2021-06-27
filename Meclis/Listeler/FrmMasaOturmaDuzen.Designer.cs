
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
            this.listViewVekil = new System.Windows.Forms.ListView();
            this.btnAktar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // chkListVekil
            // 
            this.chkListVekil.FormattingEnabled = true;
            this.chkListVekil.Location = new System.Drawing.Point(12, 12);
            this.chkListVekil.Name = "chkListVekil";
            this.chkListVekil.Size = new System.Drawing.Size(278, 649);
            this.chkListVekil.TabIndex = 0;
            // 
            // listViewVekil
            // 
            this.listViewVekil.HideSelection = false;
            this.listViewVekil.Location = new System.Drawing.Point(587, 12);
            this.listViewVekil.Name = "listViewVekil";
            this.listViewVekil.Size = new System.Drawing.Size(445, 619);
            this.listViewVekil.TabIndex = 1;
            this.listViewVekil.UseCompatibleStateImageBehavior = false;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(352, 169);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(136, 57);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            // 
            // FrmMasaOturmaDuzen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 671);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.listViewVekil);
            this.Controls.Add(this.chkListVekil);
            this.Name = "FrmMasaOturmaDuzen";
            this.Text = "FrmMasaOturmaDuzen";
            this.Load += new System.EventHandler(this.FrmMasaOturmaDuzen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckedListBox chkListVekil;
        private System.Windows.Forms.ListView listViewVekil;
        private System.Windows.Forms.Button btnAktar;
    }
}