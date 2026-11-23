namespace WebBrowserApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sosialMediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instagramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facebookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telegramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aletlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arxaRengToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yaziRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.capEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boyutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kicildToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cixisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elaqeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sosialMediaToolStripMenuItem,
            this.aletlerToolStripMenuItem,
            this.elaqeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sosialMediaToolStripMenuItem
            // 
            this.sosialMediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instagramToolStripMenuItem,
            this.youtubeToolStripMenuItem,
            this.facebookToolStripMenuItem,
            this.telegramToolStripMenuItem});
            this.sosialMediaToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.sosialMediaToolStripMenuItem.Name = "sosialMediaToolStripMenuItem";
            this.sosialMediaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sosialMediaToolStripMenuItem.Text = "Sosial media";
            // 
            // instagramToolStripMenuItem
            // 
            this.instagramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("instagramToolStripMenuItem.Image")));
            this.instagramToolStripMenuItem.Name = "instagramToolStripMenuItem";
            this.instagramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instagramToolStripMenuItem.Text = "Instagram";
            this.instagramToolStripMenuItem.Click += new System.EventHandler(this.instagramToolStripMenuItem_Click);
            // 
            // youtubeToolStripMenuItem
            // 
            this.youtubeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("youtubeToolStripMenuItem.Image")));
            this.youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            this.youtubeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.youtubeToolStripMenuItem.Text = "Youtube";
            this.youtubeToolStripMenuItem.Click += new System.EventHandler(this.youtubeToolStripMenuItem_Click);
            // 
            // facebookToolStripMenuItem
            // 
            this.facebookToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("facebookToolStripMenuItem.Image")));
            this.facebookToolStripMenuItem.Name = "facebookToolStripMenuItem";
            this.facebookToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facebookToolStripMenuItem.Text = "Facebook";
            this.facebookToolStripMenuItem.Click += new System.EventHandler(this.facebookToolStripMenuItem_Click);
            // 
            // telegramToolStripMenuItem
            // 
            this.telegramToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("telegramToolStripMenuItem.Image")));
            this.telegramToolStripMenuItem.Name = "telegramToolStripMenuItem";
            this.telegramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.telegramToolStripMenuItem.Text = "Telegram";
            this.telegramToolStripMenuItem.Click += new System.EventHandler(this.telegramToolStripMenuItem_Click);
            // 
            // aletlerToolStripMenuItem
            // 
            this.aletlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxaRengToolStripMenuItem,
            this.yaziRengiToolStripMenuItem,
            this.capEtToolStripMenuItem,
            this.boyutToolStripMenuItem,
            this.kicildToolStripMenuItem,
            this.cixisToolStripMenuItem});
            this.aletlerToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.aletlerToolStripMenuItem.Name = "aletlerToolStripMenuItem";
            this.aletlerToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.aletlerToolStripMenuItem.Text = "Alətlər";
            // 
            // arxaRengToolStripMenuItem
            // 
            this.arxaRengToolStripMenuItem.Name = "arxaRengToolStripMenuItem";
            this.arxaRengToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.arxaRengToolStripMenuItem.Text = "Arxa rəng";
            this.arxaRengToolStripMenuItem.Click += new System.EventHandler(this.arxaRengToolStripMenuItem_Click);
            // 
            // yaziRengiToolStripMenuItem
            // 
            this.yaziRengiToolStripMenuItem.Name = "yaziRengiToolStripMenuItem";
            this.yaziRengiToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.yaziRengiToolStripMenuItem.Text = "Yazı rəngi";
            this.yaziRengiToolStripMenuItem.Click += new System.EventHandler(this.yaziRengiToolStripMenuItem_Click);
            // 
            // capEtToolStripMenuItem
            // 
            this.capEtToolStripMenuItem.Name = "capEtToolStripMenuItem";
            this.capEtToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.capEtToolStripMenuItem.Text = "Çap et";
            this.capEtToolStripMenuItem.Click += new System.EventHandler(this.capEtToolStripMenuItem_Click);
            // 
            // boyutToolStripMenuItem
            // 
            this.boyutToolStripMenuItem.Name = "boyutToolStripMenuItem";
            this.boyutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.boyutToolStripMenuItem.Text = "Böyüt";
            this.boyutToolStripMenuItem.Click += new System.EventHandler(this.boyutToolStripMenuItem_Click);
            // 
            // kicildToolStripMenuItem
            // 
            this.kicildToolStripMenuItem.Name = "kicildToolStripMenuItem";
            this.kicildToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.kicildToolStripMenuItem.Text = "Kiçilt";
            this.kicildToolStripMenuItem.Click += new System.EventHandler(this.kicildToolStripMenuItem_Click);
            // 
            // cixisToolStripMenuItem
            // 
            this.cixisToolStripMenuItem.Name = "cixisToolStripMenuItem";
            this.cixisToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.cixisToolStripMenuItem.Text = "Çıxış";
            this.cixisToolStripMenuItem.Click += new System.EventHandler(this.cixisToolStripMenuItem_Click);
            // 
            // elaqeToolStripMenuItem
            // 
            this.elaqeToolStripMenuItem.ForeColor = System.Drawing.Color.DarkOrange;
            this.elaqeToolStripMenuItem.Name = "elaqeToolStripMenuItem";
            this.elaqeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.elaqeToolStripMenuItem.Text = "Əlaqə";
            this.elaqeToolStripMenuItem.Click += new System.EventHandler(this.elaqeToolStripMenuItem_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 24);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(800, 426);
            this.webView21.TabIndex = 1;
            this.webView21.ZoomFactor = 1D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Brauzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sosialMediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instagramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facebookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telegramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aletlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arxaRengToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yaziRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem capEtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boyutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kicildToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cixisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elaqeToolStripMenuItem;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
