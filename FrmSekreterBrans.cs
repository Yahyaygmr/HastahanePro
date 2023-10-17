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
    public partial class FrmSekreterBrans : Form
    {
        public FrmSekreterBrans()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmSekreterBrans_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            da.Fill(dt);
            DgwBransListesi.DataSource = dt;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Branslar (BransAd) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtBransAd.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Tamamlandı.");
        }
        private void DgwBransListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = DgwBransListesi.SelectedCells[0].RowIndex;
            TxtBransrId.Text = DgwBransListesi.Rows[secilen].Cells[0].Value.ToString();
            TxtBransAd.Text = DgwBransListesi.Rows[secilen].Cells[1].Value.ToString();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Branslar Set BransAd=@d1 where BransId=@d2", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtBransAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtBransrId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete From Tbl_Branslar where BransId=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtBransrId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Kaydı Silindi");
        }
    }
}
