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
    public partial class ogrenciderslistele : Form
    {
        public ogrenciderslistele()
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
        private void ogrenciderslistele_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int ogrencidersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var ogrencidersbul = db.ogrenciderstablo.Find(ogrencidersID);
                db.ogrenciderstablo.Remove(ogrencidersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Ve Öğrenci İlişkisi Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Ogrenci")
            {
                {
                    var arama = textBox1.Text;
                    var sonuc = (from x in db.ogrenciderstablo
                                 where x.ogrencilertablo.ogrenciadsoyad.Contains(arama)
                                 select new
                                 {
                                     x.ogrencidersid,
                                     x.derstablo.dersadi,
                                     x.ogrencilertablo.ogrenciadsoyad

                                 }).ToList();
                    dataGridView1.DataSource = sonuc.ToList();


                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
