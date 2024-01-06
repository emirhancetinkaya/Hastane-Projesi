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
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }
        SqlBağlantısı bgl = new SqlBağlantısı();
        private void btnhastakayıtyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(hastaadı,hastasoyadı,hastatc,hastatelefon,hastaşifre,hastacinsiyet)values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.bağlantı());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", msktc.Text);
            komut.Parameters.AddWithValue("@p4",msktelefon.Text);
            komut.Parameters.AddWithValue("@p5",txtşifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbcinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.bağlantı().Close();
            MessageBox.Show("kaydınız gerçekleşmiştir şifreniz :" + txtşifre.Text,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
