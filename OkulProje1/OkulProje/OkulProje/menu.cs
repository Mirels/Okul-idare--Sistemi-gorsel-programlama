using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

      

   
        private void button3_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void öğrenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            derslistele derslistele = new derslistele();
            derslistele.Show();
        }

        private void kaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dersekran derspanel = new dersekran();
            derspanel.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            okulyönetimekran oklyonetim = new okulyönetimekran();
            oklyonetim.Show();
        }

        private void girişToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrenciekran ogrpanel = new ogrenciekran();
            ogrpanel.Show();
        }

        private void öĞRENCİDERSPANELİToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void girişToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ogrencidersekran derspanel = new ogrencidersekran();
            derspanel.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void araToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 görevlilistele = new Form1();
            görevlilistele.Show();

        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrencilistele ogrencilistele = new ogrencilistele();
            ogrencilistele.Show();
        }

        private void listeleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ogrenciderslistele ogrenciderslistele = new ogrenciderslistele();
            ogrenciderslistele.Show();
        }
    }
}
