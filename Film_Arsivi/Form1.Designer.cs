namespace Film_Arsivi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTamEkran = new System.Windows.Forms.Button();
            this.btnHakkimizda = new System.Windows.Forms.Button();
            this.btnRenkDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1384, 100);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(362, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Listesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1207, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnKaydet);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.txtLink);
            this.groupBox3.Controls.Add(this.txtKategori);
            this.groupBox3.Controls.Add(this.txtFilmAd);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(0, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(356, 450);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Film";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Link:";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(121, 55);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(211, 30);
            this.txtFilmAd.TabIndex = 3;
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(121, 97);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(211, 30);
            this.txtKategori.TabIndex = 4;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(121, 135);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(211, 30);
            this.txtLink.TabIndex = 5;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Controls.Add(this.btnRenkDegistir);
            this.groupBox4.Controls.Add(this.btnHakkimizda);
            this.groupBox4.Controls.Add(this.btnTamEkran);
            this.groupBox4.Location = new System.Drawing.Point(17, 248);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 196);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(121, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(211, 33);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnTamEkran
            // 
            this.btnTamEkran.Location = new System.Drawing.Point(11, 26);
            this.btnTamEkran.Name = "btnTamEkran";
            this.btnTamEkran.Size = new System.Drawing.Size(309, 36);
            this.btnTamEkran.TabIndex = 7;
            this.btnTamEkran.Text = "Tam Ekran";
            this.btnTamEkran.UseVisualStyleBackColor = true;
            this.btnTamEkran.Click += new System.EventHandler(this.btnTamEkran_Click);
            // 
            // btnHakkimizda
            // 
            this.btnHakkimizda.Location = new System.Drawing.Point(11, 68);
            this.btnHakkimizda.Name = "btnHakkimizda";
            this.btnHakkimizda.Size = new System.Drawing.Size(309, 36);
            this.btnHakkimizda.TabIndex = 8;
            this.btnHakkimizda.Text = "Hakkımızda";
            this.btnHakkimizda.UseVisualStyleBackColor = true;
            this.btnHakkimizda.Click += new System.EventHandler(this.btnHakkimizda_Click);
            // 
            // btnRenkDegistir
            // 
            this.btnRenkDegistir.Location = new System.Drawing.Point(11, 110);
            this.btnRenkDegistir.Name = "btnRenkDegistir";
            this.btnRenkDegistir.Size = new System.Drawing.Size(309, 36);
            this.btnRenkDegistir.TabIndex = 9;
            this.btnRenkDegistir.Text = "Renk Değiştir";
            this.btnRenkDegistir.UseVisualStyleBackColor = true;
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(11, 154);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(309, 36);
            this.btnCikis.TabIndex = 10;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(446, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(453, 73);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mahemas Yazılım";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(350, 421);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.Location = new System.Drawing.Point(724, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 450);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ekran";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 26);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(641, 421);
            this.webBrowser1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1383, 594);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnRenkDegistir;
        private System.Windows.Forms.Button btnHakkimizda;
        private System.Windows.Forms.Button btnTamEkran;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

