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
    public partial class ogrencilistele : Form
    {
        public ogrencilistele()
        {
            InitializeComponent();
        }
        iremdbEntities db = new iremdbEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.ogrenciderstablo
                                        select new
                                        {
                                            x.ogrencidersid,
                                            x.derstablo.dersadi,
                                            x.ogrencilertablo.ogrenciadsoyad



                                        }).ToList();






            var derslist = db.derstablo.ToList();


        }
        private void OgrenciPanel_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void ogrencilistele_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ad Soyad")
            {
                var sonuc = from rec in db.ogrencilertablo where rec.ogrenciadsoyad.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Öğrenci No")
            {
                var sonuc = from rec in db.ogrencilertablo where rec.ogrencino.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Bolum")
            {
                var sonuc = from rec in db.ogrencilertablo where rec.ogrencibolum.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
