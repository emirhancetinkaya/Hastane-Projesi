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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string TCno;
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCno;
            SqlCommand komut = new SqlCommand("select *from tbl_hastalar where hastatc=@p1", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktelefon.Text = dr[4].ToString();
                txtşifre.Text= dr[5].ToString();
                cmbcinsiyet.Text= dr[6].ToString(); 
            }
            bgl.bağlantı().Close();
            
        }

        private void btnbilgigüncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("update tbl_hastalar set hastaadı=@p1,hastasoyadı=@p2,hastatelefon=@p3,hastaşifre=@p4,hastacinsiyet=@p5 where hastatc=@p6", bgl.bağlantı());
            komut2.Parameters.AddWithValue("@p1", txtad.Text);
            komut2.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@p3", msktelefon.Text);
            komut2.Parameters.AddWithValue("@p4", txtşifre.Text);
            komut2.Parameters.AddWithValue("@p5", cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", msktc.Text);
            komut2.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("bilgileriniz güncellendi", "bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
