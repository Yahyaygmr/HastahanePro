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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            //Tc Çekme
            LblTcNo.Text = tc;

            //AdSoyad Çekme

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt);
            DgwRandevGecmis.DataSource = dt;

            //branş
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + CmbBrans.Text + "' and RandevuDoktor='" + CmbDoktor.Text +"' and RandevuDurum=0", bgl.baglanti());
            da.Fill(dt);
            DgwRandevuAktif.DataSource = dt;
        }

        private void LinkLblBilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TcNo = tc;
            fr.Show();
        }

        private void DgwRandevuAktif_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwRandevuAktif.SelectedCells[0].RowIndex;
            TxtRandevuId.Text = DgwRandevuAktif.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where RandevuId=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTcNo.Text);
            komut.Parameters.AddWithValue("@p2", RTxtSikayet.Text);
            komut.Parameters.AddWithValue("@p3", TxtRandevuId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }
    }
}
