using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Arsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-0QRD6EF;Initial Catalog=FilmArsivim;Integrated Security=True");
        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Filmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Filmler (Ad, Kategori, Link) values (@p1, @p2, @p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Filmi listenize başarıyla eklediniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filmler();


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) //DataGrid in özelliklerinden Event ın içindeki CellContentDoubleClick e çift tıklayarak kodu buraya yazacağız. Çünkü Film listesindeki filmlerden birine çift tıkladığımızda filmin açılmasını istiyoruz.
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); //hücreye üç yazdık çünkü sql deki tablomuzda sütunları saymaya 0 dan başladığımız için ve link de dördüncü sütunda olduğundan dolayı

            webBrowser1.Navigate(link);
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Mahemas yazılım tarafından 11 mayıs 2023'te yazılmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {

        }
    }
}
