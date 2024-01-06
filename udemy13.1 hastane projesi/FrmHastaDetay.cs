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

namespace udemy13._1_hastane_projesi
{
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        { 
            lbltc.Text = tc;
            //AD SOYAD ÇEKME
            SqlCommand komut = new SqlCommand("select hastaadı,hastasoyadı from tbl_hastalar where hastatc=@p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr =komut.ExecuteReader();
            while(dr.Read())
            {
                lbladsoyad.Text = (dr[0] + " " + dr[1]);
            }
            bgl.bağlantı().Close();

            //RANDEVU GEÇMİŞİ
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select *from tbl_randevular where hastatc = " + tc, bgl.bağlantı());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //BRANÇ ÇEKME
            SqlCommand komut2 = new SqlCommand("select branşad from tbl_branşlar", bgl.bağlantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.bağlantı().Close();
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select Doktorad,doktorsoyad from Tbl_Doktorlar where doktorbranş=@p1", bgl.bağlantı());
            komut3.Parameters.AddWithValue("@p1", cmbbranş.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbdoktor.Items.Add(dr3[0]+" " + dr3[1]);
            }
            bgl.bağlantı().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tbl_Randevular where Randevudoktor='" + cmbdoktor.Text + "'and randevudurum=0", bgl.bağlantı());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgidüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = lbltc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[seçilen].Cells[0].Value.ToString();
        }

        private void btnrandevual_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastaşikayet=@p2 where randevuid=@p3", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2",rchşikayet.Text);
            komut.Parameters.AddWithValue("@p3",txtid.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("Randevu alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
