using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OkulProje
{
    public partial class derslistele : Form
    {
        public derslistele()
        {
            InitializeComponent();
        }
        iremdbEntities db = new iremdbEntities();

        void listele()
        {
            dataGridView1.DataSource = (from x in db.derstablo
                                        select new
                                        {
                                            x.dersid,
                                            x.dersadi,
                                            x.derskredisi,
                                            x.okulyonetimtablo.yonetimadsoyad

                                        }).ToList();



            //dataGridView1.Columns[4].Visible = false;

            var derslist = db.derstablo.ToList();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void derslistele_Load(object sender, EventArgs e)
        {
            listele();
            var ogretmenler = (from x in db.okulyonetimtablo
                               where x.yonetimtipi == "12"
                               select new
                               {
                                   x.yonetimid,
                                   x.yonetimadsoyad

                               }).ToList();
            /*
            comboBox1.ValueMember = "yonetimid";
            comboBox1.DisplayMember = "yonetimadsoyad";
            comboBox1.DataSource = ogretmenler;
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int DersID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var dersbul = db.derstablo.Find(DersID);
                db.derstablo.Remove(dersbul);
                db.SaveChanges();
                MessageBox.Show("Ders Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }
    }
}
