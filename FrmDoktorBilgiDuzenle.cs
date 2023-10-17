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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        public string TcNo;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            MskDoktorTc.Text = TcNo;

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskDoktorTc.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBrans.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTc=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", MskDoktorTc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler Güncellendi");
            this.Close();
        }
    }
}
