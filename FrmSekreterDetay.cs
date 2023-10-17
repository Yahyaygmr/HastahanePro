using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastahanePro
{
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TcNo;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTcNo.Text = TcNo;
            //Ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler where SekreterTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TcNo);
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                LblAdSoyad.Text = reader[0].ToString();
            }
            bgl.baglanti().Close();

            //Branşları çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            DgwBranslar.DataSource = dt;

            //Doktorları çekme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select (DoktorAd + ' ' + DoktorSoyad) as 'Doktorlar' ,DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            DgwDoktorlar.DataSource = dt1;

            //Branşları comboboxa Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar",bgl.baglanti());
            SqlDataReader reader2 = komut2.ExecuteReader();
            while(reader2.Read())
            {
                CmbBrans.Items.Add(reader2[0]);
            }bgl.baglanti().Close();

        }

        private void BtnRandevuKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@p1", MTxtTarih.Text);
            komutKaydet.Parameters.AddWithValue("@p2", MTxtSaat.Text);
            komutKaydet.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@p4", CmbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu.");
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            //Doktorları Comboboxa Çekme

            SqlCommand komut3 = new SqlCommand("Select (DoktorAd + ' ' + DoktorSoyad) From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader reader3 = komut3.ExecuteReader();
            while (reader3.Read())
            {
                CmbDoktor.Items.Add(reader3[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (Duyuru) values (@d1)",bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RTxtDuyuruOlustur.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu.");
        }

        private void BtnDoktorPaneli_Click(object sender, EventArgs e)
        {
            FrmSekreterDoktorPaneli fr = new FrmSekreterDoktorPaneli();
            fr.Show();
        }

        private void BtnBransPaneli_Click(object sender, EventArgs e)
        {
            FrmSekreterBrans fr = new FrmSekreterBrans();
            fr.Show();
        }
    }
}
