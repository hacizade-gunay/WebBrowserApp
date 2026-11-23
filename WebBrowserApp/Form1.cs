using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebBrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Menyu rəngləri tətbiq olunsun deyə sistem render rejimi
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            ApplyMenuColors(Color.Black, Color.DarkOrange);
        }

        // Proqram başlayanda Google açılır
        private void Form1_Load(object sender, EventArgs e)
        {
            webView21.Source = new Uri("https://www.google.az");
        }

        // ---------- Sosial media ----------
        private void instagramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("https://www.instagram.com");
        }

        private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("https://www.youtube.com");
        }

        private void facebookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("https://www.facebook.com");
        }

        private void telegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open("https://www.telegram.org");
        }

        private void Open(string url)
        {
            webView21.Source = new Uri(url);
        }

        // ---------- Alətlər ----------
        private void arxaRengToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = menuStrip1.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyMenuColors(colorDialog1.Color, menuStrip1.ForeColor);
            }
        }

        private void yaziRengiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = menuStrip1.ForeColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ApplyMenuColors(menuStrip1.BackColor, colorDialog1.Color);
            }
        }

        private void capEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.CoreWebView2 != null)
            {
                webView21.CoreWebView2.ShowPrintUI();
            }
        }

        private void boyutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor < 5.0)
            {
                webView21.ZoomFactor += 0.1;
            }
        }

        private void kicildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (webView21.ZoomFactor > 0.3)
            {
                webView21.ZoomFactor -= 0.1;
            }
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cavab = MessageBox.Show("Çıxış edilsinmi?", "Çıxış",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cavab == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void elaqeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Əlaqə üçün məlumatları bura əlavə edin.", "Əlaqə");
        }

        // ---------- Köməkçi ----------
        // Menyunun və bütün alt bəndlərin arxa və yazı rəngini dəyişir
        private void ApplyMenuColors(Color back, Color fore)
        {
            menuStrip1.BackColor = back;
            menuStrip1.ForeColor = fore;
            foreach (ToolStripItem item in menuStrip1.Items)
            {
                ColorItem(item, back, fore);
            }
        }

        private void ColorItem(ToolStripItem item, Color back, Color fore)
        {
            item.BackColor = back;
            item.ForeColor = fore;
            ToolStripMenuItem menuItem = item as ToolStripMenuItem;
            if (menuItem != null)
            {
                menuItem.DropDown.BackColor = back;
                foreach (ToolStripItem sub in menuItem.DropDownItems)
                {
                    ColorItem(sub, back, fore);
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
