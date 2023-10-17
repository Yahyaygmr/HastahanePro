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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        public string TcNo;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTcNo.Text = TcNo;

            //Doktor ad soyad
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTcNo.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='" + LblAdSoyad.Text + "'",bgl.baglanti());
            da.Fill(dt);
            DgwRandevuListesi.DataSource = dt;

        }

        private void BtnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TcNo = TcNo;
            fr.Show();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void DgwRandevuListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwRandevuListesi.SelectedCells[0].RowIndex;
            RTxtSikayet.Text = DgwRandevuListesi.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
