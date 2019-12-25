namespace UcusBilgileriAppEFCodeFirst
{
    partial class frmHavayoluListe
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
            this.grdHavayollari = new System.Windows.Forms.DataGridView();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.clmIdHavayolu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHavayoluAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayollari)).BeginInit();
            this.SuspendLayout();
            // 
            // grdHavayollari
            // 
            this.grdHavayollari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdHavayollari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHavayollari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmIdHavayolu,
            this.clmHavayoluAdi});
            this.grdHavayollari.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdHavayollari.Location = new System.Drawing.Point(0, 0);
            this.grdHavayollari.Name = "grdHavayollari";
            this.grdHavayollari.Size = new System.Drawing.Size(800, 249);
            this.grdHavayollari.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(349, 309);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(126, 38);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // clmIdHavayolu
            // 
            this.clmIdHavayolu.DataPropertyName = "Id_Havayolu";
            this.clmIdHavayolu.HeaderText = "Havayolu Id";
            this.clmIdHavayolu.Name = "clmIdHavayolu";
            // 
            // clmHavayoluAdi
            // 
            this.clmHavayoluAdi.DataPropertyName = "Havayolu_Adi";
            this.clmHavayoluAdi.HeaderText = "Havayolu Adı";
            this.clmHavayoluAdi.Name = "clmHavayoluAdi";
            // 
            // frmHavayoluListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grdHavayollari);
            this.Name = "frmHavayoluListe";
            this.Text = "frmHavaalaniListe";
            this.Load += new System.EventHandler(this.frmHavayoluListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHavayollari)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdHavayollari;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIdHavayolu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHavayoluAdi;
    }
}