using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udemy13._1_hastane_projesi
{
    public partial class FrmGirişler : Form
    {
        public FrmGirişler()
        {
            InitializeComponent();
        }

        private void btnhastagirişi_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş fr = new FrmHastaGiriş();
            fr.Show();
            this.Hide();
        }

        private void btndoktorgirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş fr = new FrmDoktorGiriş();
            fr.Show();
            this.Hide();
        }

        private void btnsekretergirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiriş fr = new FrmSekreterGiriş();
            fr.Show();
            this.Hide();
        }
    }
}
