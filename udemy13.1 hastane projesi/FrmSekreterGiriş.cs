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
    public partial class FrmSekreterGiriş : Form
    {
        public FrmSekreterGiriş()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void btngirişyap_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("select *from tbl_sekreterler where sekretertc=@p1 and sekreterşifre=@p2", bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtşifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = msktc.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı TC & Şifre");
            }
            bgl.bağlantı().Close();
        }
    }
}
