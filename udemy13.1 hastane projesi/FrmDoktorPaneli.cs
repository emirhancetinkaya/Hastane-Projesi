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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("select *from tbl_doktorlar", bgl.bağlantı());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branşları comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("select branşad from tbl_branşlar", bgl.bağlantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.bağlantı().Close();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_doktorlar(doktorad,doktorsoyad,doktorbranş,doktortc,doktorşifre)values(@d1,@d2,@d3,@d4,@d5)", bgl.bağlantı());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@d4",msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtşifre.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("doktor eklendi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[seçilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[seçilen].Cells[2].Value.ToString();
            cmbbranş.Text = dataGridView1.Rows[seçilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[seçilen].Cells[4].Value.ToString();
            txtşifre.Text = dataGridView1.Rows[seçilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_doktorlar where doktortc=@p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1",msktc.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("kayıt silindi", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@d1,doktorsoyad=@d2,doktorbranş=@d3,doktorşifre=@d5 where doktortc=@d4", bgl.bağlantı());
            komut.Parameters.AddWithValue("@d1", txtad.Text);
            komut.Parameters.AddWithValue("@d2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@d3", cmbbranş.Text);
            komut.Parameters.AddWithValue("@d4", msktc.Text);
            komut.Parameters.AddWithValue("@d5", txtşifre.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("doktor GÜNCELLENDİ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
