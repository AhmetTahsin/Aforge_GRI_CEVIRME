namespace Görüntü_İşleme_Projesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renkAlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.renkKarıştırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griYöntemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bT709AlgoritmasıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaYöntemiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarımıYöntemiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kapatToolStripMenuItem,
            this.renkAlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kapatToolStripMenuItem
            // 
            this.kapatToolStripMenuItem.Name = "kapatToolStripMenuItem";
            this.kapatToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.kapatToolStripMenuItem.Text = "Kapat";
            this.kapatToolStripMenuItem.Click += new System.EventHandler(this.kapatToolStripMenuItem_Click);
            // 
            // renkAlToolStripMenuItem
            // 
            this.renkAlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renkAlToolStripMenuItem1,
            this.renkKarıştırToolStripMenuItem,
            this.griYöntemleriToolStripMenuItem});
            this.renkAlToolStripMenuItem.Name = "renkAlToolStripMenuItem";
            this.renkAlToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.renkAlToolStripMenuItem.Text = "İşlemler";
            // 
            // renkAlToolStripMenuItem1
            // 
            this.renkAlToolStripMenuItem1.Name = "renkAlToolStripMenuItem1";
            this.renkAlToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.renkAlToolStripMenuItem1.Text = "Renk Al";
            this.renkAlToolStripMenuItem1.Click += new System.EventHandler(this.renkAlToolStripMenuItem1_Click);
            // 
            // renkKarıştırToolStripMenuItem
            // 
            this.renkKarıştırToolStripMenuItem.Name = "renkKarıştırToolStripMenuItem";
            this.renkKarıştırToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.renkKarıştırToolStripMenuItem.Text = "Renk Karıştır";
            this.renkKarıştırToolStripMenuItem.Click += new System.EventHandler(this.renkKarıştırToolStripMenuItem_Click);
            // 
            // griYöntemleriToolStripMenuItem
            // 
            this.griYöntemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaToolStripMenuItem,
            this.bT709AlgoritmasıToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem,
            this.lumaYöntemiToolStripMenuItem1,
            this.kanalÇıkarımıYöntemiToolStripMenuItem});
            this.griYöntemleriToolStripMenuItem.Name = "griYöntemleriToolStripMenuItem";
            this.griYöntemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.griYöntemleriToolStripMenuItem.Text = "Gri Yöntemleri";
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            this.ortalamaToolStripMenuItem.Click += new System.EventHandler(this.ortalamaToolStripMenuItem_Click);
            // 
            // bT709AlgoritmasıToolStripMenuItem
            // 
            this.bT709AlgoritmasıToolStripMenuItem.Name = "bT709AlgoritmasıToolStripMenuItem";
            this.bT709AlgoritmasıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bT709AlgoritmasıToolStripMenuItem.Text = "BT-709 Algoritması";
            this.bT709AlgoritmasıToolStripMenuItem.Click += new System.EventHandler(this.bT709AlgoritmasıToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem
            // 
            this.lumaYöntemiToolStripMenuItem.Name = "lumaYöntemiToolStripMenuItem";
            this.lumaYöntemiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lumaYöntemiToolStripMenuItem.Text = "Açıklık Yöntemi";
            this.lumaYöntemiToolStripMenuItem.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem_Click);
            // 
            // lumaYöntemiToolStripMenuItem1
            // 
            this.lumaYöntemiToolStripMenuItem1.Name = "lumaYöntemiToolStripMenuItem1";
            this.lumaYöntemiToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.lumaYöntemiToolStripMenuItem1.Text = "Luma Yöntemi";
            this.lumaYöntemiToolStripMenuItem1.Click += new System.EventHandler(this.lumaYöntemiToolStripMenuItem1_Click);
            // 
            // kanalÇıkarımıYöntemiToolStripMenuItem
            // 
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Name = "kanalÇıkarımıYöntemiToolStripMenuItem";
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Text = "Kanal Çıkarımı Yöntemi";
            this.kanalÇıkarımıYöntemiToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıYöntemiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem kapatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkAlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem renkKarıştırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griYöntemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bT709AlgoritmasıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaYöntemiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıYöntemiToolStripMenuItem;
    }
}

