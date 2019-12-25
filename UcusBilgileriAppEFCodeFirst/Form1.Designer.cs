namespace UcusBilgileriAppEFCodeFirst
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuHavayollariIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayollari = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHavayollariListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHavayollariIslemleri});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuHavayollariIslemleri
            // 
            this.menuHavayollariIslemleri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHavayollari,
            this.menuHavayollariListe});
            this.menuHavayollariIslemleri.Name = "menuHavayollariIslemleri";
            this.menuHavayollariIslemleri.Size = new System.Drawing.Size(125, 20);
            this.menuHavayollariIslemleri.Text = "Havayollari İslemleri";
            // 
            // menuHavayollari
            // 
            this.menuHavayollari.Name = "menuHavayollari";
            this.menuHavayollari.Size = new System.Drawing.Size(221, 22);
            this.menuHavayollari.Text = "Havayollari Ekle Sil Güncelle";
            this.menuHavayollari.Click += new System.EventHandler(this.menuHavayollari_Click);
            // 
            // menuHavayollariListe
            // 
            this.menuHavayollariListe.Name = "menuHavayollariListe";
            this.menuHavayollariListe.Size = new System.Drawing.Size(221, 22);
            this.menuHavayollariListe.Text = "Havayollari Liste";
            this.menuHavayollariListe.Click += new System.EventHandler(this.menuHavayollariListe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuHavayollariIslemleri;
        private System.Windows.Forms.ToolStripMenuItem menuHavayollari;
        private System.Windows.Forms.ToolStripMenuItem menuHavayollariListe;
    }
}

