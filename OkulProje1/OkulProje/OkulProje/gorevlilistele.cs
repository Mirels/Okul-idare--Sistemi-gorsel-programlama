using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OkulProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        iremdbEntities db = new iremdbEntities();
        

        void listele()
        {
            dataGridView1.DataSource = db.okulyonetimtablo.ToList();
            dataGridView1.Columns[4].Visible = false;

            var yonetimlist = db.okulyonetimtablo.ToList();


        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            listele();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult sor = new DialogResult();
            sor = MessageBox.Show("Seçilen Kayıt Silinecektir. Onaylıyor musunuz?", "Sistem Mesajı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sor == DialogResult.Yes)
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                int YonetimID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);


                var yonetimbul = db.okulyonetimtablo.Find(YonetimID);
                db.okulyonetimtablo.Remove(yonetimbul);
                db.SaveChanges();
                MessageBox.Show("Yönetim Kayıdı Silindi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listele();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Görevli Adı")
            {
                var sonuc = from rec in db.okulyonetimtablo where rec.yonetimadsoyad.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
            else if (comboBox1.SelectedItem == "Görevi")
            {
                var sonuc = from rec in db.okulyonetimtablo where rec.yonetimgorevi.Contains(textBox1.Text) select rec;
                dataGridView1.DataSource = sonuc.ToList();
            }
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
