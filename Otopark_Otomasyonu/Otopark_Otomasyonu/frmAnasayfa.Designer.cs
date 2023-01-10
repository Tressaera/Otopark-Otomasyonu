
namespace Otopark_Otomasyonu
{
    partial class frmAnasayfa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnasayfa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçOtoparkÇıkışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.markaTool = new System.Windows.Forms.ToolStripMenuItem();
            this.seriTool = new System.Windows.Forms.ToolStripMenuItem();
            this.satışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.btnOtoparkYer = new System.Windows.Forms.Button();
            this.btnOtoparkCik = new System.Windows.Forms.Button();
            this.btnAracOtoparkGirisi = new System.Windows.Forms.Button();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.btnMusteriListele = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.araçİşlemleriToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.satışToolStripMenuItem,
            this.hakkımızdaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem,
            this.saatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1086, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriDüzenleToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            // 
            // müşteriDüzenleToolStripMenuItem
            // 
            this.müşteriDüzenleToolStripMenuItem.Name = "müşteriDüzenleToolStripMenuItem";
            this.müşteriDüzenleToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.müşteriDüzenleToolStripMenuItem.Text = "Müşteri Düzenle";
            // 
            // araçİşlemleriToolStripMenuItem
            // 
            this.araçİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.araçOtoparkGirişiToolStripMenuItem,
            this.araçOtoparkÇıkışıToolStripMenuItem});
            this.araçİşlemleriToolStripMenuItem.Name = "araçİşlemleriToolStripMenuItem";
            this.araçİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.araçİşlemleriToolStripMenuItem.Text = "Araç İşlemleri";
            // 
            // araçOtoparkGirişiToolStripMenuItem
            // 
            this.araçOtoparkGirişiToolStripMenuItem.Name = "araçOtoparkGirişiToolStripMenuItem";
            this.araçOtoparkGirişiToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.araçOtoparkGirişiToolStripMenuItem.Text = "Araç Otopark Girişi";
            // 
            // araçOtoparkÇıkışıToolStripMenuItem
            // 
            this.araçOtoparkÇıkışıToolStripMenuItem.Name = "araçOtoparkÇıkışıToolStripMenuItem";
            this.araçOtoparkÇıkışıToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.araçOtoparkÇıkışıToolStripMenuItem.Text = "Araç Otopark Çıkışı";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.markaTool,
            this.seriTool});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // markaTool
            // 
            this.markaTool.Name = "markaTool";
            this.markaTool.Size = new System.Drawing.Size(133, 26);
            this.markaTool.Text = "Marka";
            this.markaTool.Click += new System.EventHandler(this.markaTool_Click);
            // 
            // seriTool
            // 
            this.seriTool.Name = "seriTool";
            this.seriTool.Size = new System.Drawing.Size(133, 26);
            this.seriTool.Text = "Seri";
            this.seriTool.Click += new System.EventHandler(this.seriTool_Click);
            // 
            // satışToolStripMenuItem
            // 
            this.satışToolStripMenuItem.Name = "satışToolStripMenuItem";
            this.satışToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.satışToolStripMenuItem.Text = "Satış";
            // 
            // hakkımızdaToolStripMenuItem
            // 
            this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
            this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.yardımToolStripMenuItem.Text = "Yardım ";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            // 
            // saatToolStripMenuItem
            // 
            this.saatToolStripMenuItem.Margin = new System.Windows.Forms.Padding(200, 0, 0, 0);
            this.saatToolStripMenuItem.Name = "saatToolStripMenuItem";
            this.saatToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btnSeri);
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnSatis);
            this.panel1.Controls.Add(this.btnOtoparkYer);
            this.panel1.Controls.Add(this.btnOtoparkCik);
            this.panel1.Controls.Add(this.btnAracOtoparkGirisi);
            this.panel1.Controls.Add(this.btnMusteriEkle);
            this.panel1.Controls.Add(this.btnMusteriListele);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 169);
            this.panel1.TabIndex = 1;
            // 
            // btnSeri
            // 
            this.btnSeri.FlatAppearance.BorderSize = 0;
            this.btnSeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeri.ImageKey = "category-settings.png";
            this.btnSeri.ImageList = this.ımageList1;
            this.btnSeri.Location = new System.Drawing.Point(927, 14);
            this.btnSeri.Name = "btnSeri";
            this.btnSeri.Size = new System.Drawing.Size(130, 122);
            this.btnSeri.TabIndex = 0;
            this.btnSeri.Text = "Seri";
            this.btnSeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeri.UseVisualStyleBackColor = true;
            this.btnSeri.Click += new System.EventHandler(this.btnSeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "9811.jpg");
            this.ımageList1.Images.SetKeyName(1, "arac-girisi.png");
            this.ımageList1.Images.SetKeyName(2, "arac-girisi-2.jpg");
            this.ımageList1.Images.SetKeyName(3, "category-settings.png");
            this.ımageList1.Images.SetKeyName(4, "exit.png");
            this.ımageList1.Images.SetKeyName(5, "general office.png");
            this.ımageList1.Images.SetKeyName(6, "level-up.png");
            this.ımageList1.Images.SetKeyName(7, "log.png");
            this.ımageList1.Images.SetKeyName(8, "money-order.png");
            this.ımageList1.Images.SetKeyName(9, "müşteri.jpg");
            this.ımageList1.Images.SetKeyName(10, "parking-sign.png");
            this.ımageList1.Images.SetKeyName(11, "save.png");
            this.ımageList1.Images.SetKeyName(12, "simpline.png");
            this.ımageList1.Images.SetKeyName(13, "marka.png");
            // 
            // btnMarka
            // 
            this.btnMarka.FlatAppearance.BorderSize = 0;
            this.btnMarka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarka.ImageKey = "marka.png";
            this.btnMarka.ImageList = this.ımageList1;
            this.btnMarka.Location = new System.Drawing.Point(791, 14);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(130, 122);
            this.btnMarka.TabIndex = 0;
            this.btnMarka.Text = "Marka";
            this.btnMarka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.FlatAppearance.BorderSize = 0;
            this.btnSatis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatis.ImageKey = "money-order.png";
            this.btnSatis.ImageList = this.ımageList1;
            this.btnSatis.Location = new System.Drawing.Point(661, 14);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(130, 122);
            this.btnSatis.TabIndex = 0;
            this.btnSatis.Text = "Satış";
            this.btnSatis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // btnOtoparkYer
            // 
            this.btnOtoparkYer.FlatAppearance.BorderSize = 0;
            this.btnOtoparkYer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtoparkYer.ImageKey = "arac-girisi-2.jpg";
            this.btnOtoparkYer.ImageList = this.ımageList1;
            this.btnOtoparkYer.Location = new System.Drawing.Point(531, 14);
            this.btnOtoparkYer.Name = "btnOtoparkYer";
            this.btnOtoparkYer.Size = new System.Drawing.Size(130, 122);
            this.btnOtoparkYer.TabIndex = 0;
            this.btnOtoparkYer.Text = "Otopark Yerleri";
            this.btnOtoparkYer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtoparkYer.UseVisualStyleBackColor = true;
            this.btnOtoparkYer.Click += new System.EventHandler(this.btnOtoparkYer_Click);
            // 
            // btnOtoparkCik
            // 
            this.btnOtoparkCik.FlatAppearance.BorderSize = 0;
            this.btnOtoparkCik.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtoparkCik.ImageKey = "level-up.png";
            this.btnOtoparkCik.ImageList = this.ımageList1;
            this.btnOtoparkCik.Location = new System.Drawing.Point(401, 14);
            this.btnOtoparkCik.Name = "btnOtoparkCik";
            this.btnOtoparkCik.Size = new System.Drawing.Size(130, 122);
            this.btnOtoparkCik.TabIndex = 0;
            this.btnOtoparkCik.Text = "Araç Otopark Çıkışı";
            this.btnOtoparkCik.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOtoparkCik.UseVisualStyleBackColor = true;
            this.btnOtoparkCik.Click += new System.EventHandler(this.btnOtoparkCik_Click);
            // 
            // btnAracOtoparkGirisi
            // 
            this.btnAracOtoparkGirisi.FlatAppearance.BorderSize = 0;
            this.btnAracOtoparkGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracOtoparkGirisi.ImageKey = "arac-girisi.png";
            this.btnAracOtoparkGirisi.ImageList = this.ımageList1;
            this.btnAracOtoparkGirisi.Location = new System.Drawing.Point(271, 14);
            this.btnAracOtoparkGirisi.Name = "btnAracOtoparkGirisi";
            this.btnAracOtoparkGirisi.Size = new System.Drawing.Size(130, 122);
            this.btnAracOtoparkGirisi.TabIndex = 0;
            this.btnAracOtoparkGirisi.Text = "Araç Otopark Girişi";
            this.btnAracOtoparkGirisi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAracOtoparkGirisi.UseVisualStyleBackColor = true;
            this.btnAracOtoparkGirisi.Click += new System.EventHandler(this.btnAracOtoparkGirisi_Click);
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.FlatAppearance.BorderSize = 0;
            this.btnMusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriEkle.ImageKey = "simpline.png";
            this.btnMusteriEkle.ImageList = this.ımageList1;
            this.btnMusteriEkle.Location = new System.Drawing.Point(11, 14);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(130, 122);
            this.btnMusteriEkle.TabIndex = 0;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            // 
            // btnMusteriListele
            // 
            this.btnMusteriListele.FlatAppearance.BorderSize = 0;
            this.btnMusteriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriListele.ImageKey = "general office.png";
            this.btnMusteriListele.ImageList = this.ımageList1;
            this.btnMusteriListele.Location = new System.Drawing.Point(141, 14);
            this.btnMusteriListele.Name = "btnMusteriListele";
            this.btnMusteriListele.Size = new System.Drawing.Size(130, 122);
            this.btnMusteriListele.TabIndex = 0;
            this.btnMusteriListele.Text = "Müşteri Listele";
            this.btnMusteriListele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMusteriListele.UseVisualStyleBackColor = true;
            this.btnMusteriListele.Click += new System.EventHandler(this.btnMusteriListele_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnasayfa";
            this.Text = "Otopark Otomasyonu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçOtoparkÇıkışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem markaTool;
        private System.Windows.Forms.ToolStripMenuItem seriTool;
        private System.Windows.Forms.ToolStripMenuItem satışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button btnSeri;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Button btnOtoparkYer;
        private System.Windows.Forms.Button btnOtoparkCik;
        private System.Windows.Forms.Button btnAracOtoparkGirisi;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.Button btnMusteriListele;
        private System.Windows.Forms.ToolStripMenuItem saatToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

