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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        SqlBağlantısı bgl= new SqlBağlantısı();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = TCnumara;

            //ad soyad çekme
            SqlCommand komut1 = new SqlCommand("select sekreteradsoyad from tbl_sekreterler where sekretertc=@p1", bgl.bağlantı());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while(dr1.Read())
            {
                lbladsoyad.Text = (dr1[0].ToString());
            }
            bgl.bağlantı().Close();

            //branşları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branşlar", bgl.bağlantı());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktor datagride aktarma
            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad + ' ' + doktorsoyad)as 'doktorlar',doktorbranş from tbl_doktorlar", bgl.bağlantı());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //branşı comboboxa aktarma
            SqlCommand komut2 = new SqlCommand("select branşad from tbl_branşlar", bgl.bağlantı());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbbranş.Items.Add(dr2[0]);
            }
            bgl.bağlantı().Close();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih,randevusaat,randevubranş,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.bağlantı());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbranş.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("randevu oluşturuldu");
        }

        private void cmbbranş_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbranş=@p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1",cmbbranş.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
                
            }
            bgl.bağlantı().Close();
        }

        private void btnduyuruoluştur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru)values (@d1)", bgl.bağlantı());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("duyuru oluşturuldu");
        }
         
        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void btnbranşpanel_Click(object sender, EventArgs e)
        {
            FrmBranş frb = new FrmBranş();
            frb.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular frd = new FrmDuyurular();
            frd.Show();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
