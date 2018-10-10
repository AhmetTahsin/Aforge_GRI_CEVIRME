using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Görüntü_İşleme_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkAlToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2 renkFormu = new Form2();
            renkFormu.ShowDialog();
        }

        private void renkKarıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 kanalFormu = new Form3();
            kanalFormu.ShowDialog();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 kanalFormu = new Form4();
            kanalFormu.ShowDialog();
        }

        private void bT709AlgoritmasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 kanalFormu = new Form5();
            kanalFormu.ShowDialog();
        }

        private void lumaYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 kanalFormu = new Form6();
            kanalFormu.ShowDialog();
        }

        private void lumaYöntemiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form7 kanalFormu = new Form7();
            kanalFormu.ShowDialog();
        }

        private void kanalÇıkarımıYöntemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 kanalFormu = new Form8();
            kanalFormu.ShowDialog();
        }
    }
}
