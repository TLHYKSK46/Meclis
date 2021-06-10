
namespace Meclis.SabitTanimlar
{
    partial class FrmVekilDetay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vekilId = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.cbGenelMerkezGorev = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vekilId);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cbGenelMerkezGorev);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 316);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // vekilId
            // 
            this.vekilId.AutoSize = true;
            this.vekilId.Location = new System.Drawing.Point(553, 107);
            this.vekilId.Name = "vekilId";
            this.vekilId.Size = new System.Drawing.Size(15, 13);
            this.vekilId.TabIndex = 59;
            this.vekilId.Text = "ıd";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(363, 174);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(161, 50);
            this.btnKaydet.TabIndex = 57;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // cbGenelMerkezGorev
            // 
            this.cbGenelMerkezGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGenelMerkezGorev.FormattingEnabled = true;
            this.cbGenelMerkezGorev.Items.AddRange(new object[] {
            "Tümü",
            "Ad Soyad",
            "TC Kimlik No",
            "İl"});
            this.cbGenelMerkezGorev.Location = new System.Drawing.Point(201, 63);
            this.cbGenelMerkezGorev.Name = "cbGenelMerkezGorev";
            this.cbGenelMerkezGorev.Size = new System.Drawing.Size(203, 26);
            this.cbGenelMerkezGorev.TabIndex = 55;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(87, 60);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 36);
            this.label19.TabIndex = 56;
            this.label19.Text = "Genel Merkez\r\nGörev";
            // 
            // FrmVekilDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 293);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVekilDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmVekilDetay";
            this.Load += new System.EventHandler(this.FrmVekilDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbGenelMerkezGorev;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Label vekilId;
    }
}