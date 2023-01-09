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

namespace Hastane_Projesi
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTc.Text = tc;

            //Ad Soyad Çekme

            SqlCommand komut = new SqlCommand("Select  SekreterAd , SekreterSoyad from Tbl_Sekreter where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //branslar çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktor Çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select  (DoktorAd + ' ' + DoktorSoyad) as Doktorlar, DoktorTC from Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

            //bransı randevuya aktarma
            SqlCommand komut1 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                CmbBrans.Items.Add(dr1[0]);

            }
            bgl.baglanti().Close();         
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut3.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut3.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut3.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();

            SqlCommand komut2 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans=@p1 ", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbDoktor.Items.Add(dr2[0] + " " + dr2[1]);

            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3= new SqlCommand("Update Tbl_Randevular set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4 where HastaTc=@p5 ",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", MskTarih.Text);
            komut3.Parameters.AddWithValue("@p2", MskSaat.Text);
            komut3.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut3.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komut3.Parameters.AddWithValue("@p5", MskTC.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MskTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut4 = new SqlCommand("insert into Tbl_Duyuru (Duyuru) values (@p1)", bgl.baglanti());
            komut4.Parameters.AddWithValue("@p1", RchDuyuru.Text);
            komut4.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli fr = new FrmDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmBransPaneli fr = new FrmBransPaneli();
            fr.Show();
        }

        private void BtnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListe fr = new FrmRandevuListe();
            fr.Show();
        }
    }
}
