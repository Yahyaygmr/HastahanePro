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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskHastaTc.Text = TcNo;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar where HastaTc="+TcNo,bgl.baglanti());
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                TxtAd.Text = reader[1].ToString();
                TxtSoyad.Text = reader[2].ToString();
                MskTelefon.Text = reader[4].ToString();
                TxtSifre.Text = reader[5].ToString();
                CmbCinsiyet.Text = reader[6].ToString();
            }
      
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTc=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2",TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3",MskTelefon.Text);
            komut2.Parameters.AddWithValue("@p4",TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5",CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6",MskHastaTc.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Güncellendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            this.Close();
        }
    }
}
