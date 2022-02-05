using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandevuYonetimSistemi.WindowsFormsUI
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void doktorYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoktorYonetimi doktorYonetimi = new DoktorYonetimi();
            doktorYonetimi.ShowDialog();
        }

        private void hastaYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HastaYonetimi hastaYonetimi = new HastaYonetimi();
            hastaYonetimi.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }

        private void randevuYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RandevuYonetimi randevuYonetimi = new RandevuYonetimi();
            randevuYonetimi.ShowDialog();
        }
    }
}
