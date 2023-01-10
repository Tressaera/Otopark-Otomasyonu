
namespace Otopark_Otomasyonu.Formlar
{
    partial class frmSatis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatis));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAdSoyadAra = new System.Windows.Forms.TextBox();
            this.txtMusteriIDAra = new System.Windows.Forms.TextBox();
            this.txtIDAra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlakaAra = new System.Windows.Forms.TextBox();
            this.txtParkYeriAra = new System.Windows.Forms.TextBox();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblKayit = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-11, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 365);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtAdSoyadAra
            // 
            this.txtAdSoyadAra.Location = new System.Drawing.Point(435, 29);
            this.txtAdSoyadAra.Name = "txtAdSoyadAra";
            this.txtAdSoyadAra.Size = new System.Drawing.Size(166, 22);
            this.txtAdSoyadAra.TabIndex = 8;
            this.txtAdSoyadAra.TextChanged += new System.EventHandler(this.txtAdSoyadAra_TextChanged);
            // 
            // txtMusteriIDAra
            // 
            this.txtMusteriIDAra.Location = new System.Drawing.Point(214, 29);
            this.txtMusteriIDAra.Name = "txtMusteriIDAra";
            this.txtMusteriIDAra.Size = new System.Drawing.Size(166, 22);
            this.txtMusteriIDAra.TabIndex = 9;
            this.txtMusteriIDAra.TextChanged += new System.EventHandler(this.txtMusteriIDAra_TextChanged);
            // 
            // txtIDAra
            // 
            this.txtIDAra.Location = new System.Drawing.Point(12, 29);
            this.txtIDAra.Name = "txtIDAra";
            this.txtIDAra.Size = new System.Drawing.Size(166, 22);
            this.txtIDAra.TabIndex = 10;
            this.txtIDAra.TextChanged += new System.EventHandler(this.txtIDAra_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(847, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Park Yeri Ara";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(646, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Plaka Ara";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(435, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ad Soyad Ara";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Müşteri ID Ara";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID Ara";
            // 
            // txtPlakaAra
            // 
            this.txtPlakaAra.Location = new System.Drawing.Point(649, 29);
            this.txtPlakaAra.Name = "txtPlakaAra";
            this.txtPlakaAra.Size = new System.Drawing.Size(166, 22);
            this.txtPlakaAra.TabIndex = 8;
            this.txtPlakaAra.TextChanged += new System.EventHandler(this.txtPlakaAra_TextChanged);
            // 
            // txtParkYeriAra
            // 
            this.txtParkYeriAra.Location = new System.Drawing.Point(850, 29);
            this.txtParkYeriAra.Name = "txtParkYeriAra";
            this.txtParkYeriAra.Size = new System.Drawing.Size(166, 22);
            this.txtParkYeriAra.TabIndex = 8;
            this.txtParkYeriAra.TextChanged += new System.EventHandler(this.txtParkYeriAra_TextChanged);
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.ForeColor = System.Drawing.Color.White;
            this.lblTutar.Location = new System.Drawing.Point(108, 464);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(70, 25);
            this.lblTutar.TabIndex = 11;
            this.lblTutar.Text = "label6";
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.BackColor = System.Drawing.Color.Transparent;
            this.lblKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayit.ForeColor = System.Drawing.Color.White;
            this.lblKayit.Location = new System.Drawing.Point(108, 513);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(70, 25);
            this.lblKayit.TabIndex = 11;
            this.lblKayit.Text = "label6";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.BackColor = System.Drawing.Color.Transparent;
            this.lblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrtalama.ForeColor = System.Drawing.Color.White;
            this.lblOrtalama.Location = new System.Drawing.Point(108, 562);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(70, 25);
            this.lblOrtalama.TabIndex = 11;
            this.lblOrtalama.Text = "label6";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.Color.Transparent;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMax.ForeColor = System.Drawing.Color.White;
            this.lblMax.Location = new System.Drawing.Point(727, 464);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(70, 25);
            this.lblMax.TabIndex = 11;
            this.lblMax.Text = "label6";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.Transparent;
            this.lblMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMin.ForeColor = System.Drawing.Color.White;
            this.lblMin.Location = new System.Drawing.Point(727, 513);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(70, 25);
            this.lblMin.TabIndex = 11;
            this.lblMin.Text = "label6";
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1086, 667);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtParkYeriAra);
            this.Controls.Add(this.txtPlakaAra);
            this.Controls.Add(this.txtAdSoyadAra);
            this.Controls.Add(this.txtMusteriIDAra);
            this.Controls.Add(this.txtIDAra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Alanı";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAdSoyadAra;
        private System.Windows.Forms.TextBox txtMusteriIDAra;
        private System.Windows.Forms.TextBox txtIDAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPlakaAra;
        private System.Windows.Forms.TextBox txtParkYeriAra;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblKayit;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblMin;
    }
}