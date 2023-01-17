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
    public partial class ogrenciekran : Form
    {
        public ogrenciekran()
        {
            InitializeComponent();
        }
        iremdbEntities db = new iremdbEntities();

      
      
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            ogrencilertablo ekle = new ogrencilertablo();
            ekle.ogrenciadsoyad = txtadsoyad.Text;
            ekle.ogrencino = txtogrencino.Text;
            ekle.ogrencidogumtarih = dateTimePicker1.Value;
            ekle.ogrencibolum = txtbolum.Text;
            ekle.ogrencikayittarih = DateTime.Now;
            db.ogrencilertablo.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kaydı Oluşturuldu.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

       

     

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int OgrenciId = Convert.ToInt32(txtid.Text);

            var guncelle = db.ogrencilertablo.Find(OgrenciId);
            guncelle.ogrenciadsoyad = txtadsoyad.Text;
            guncelle.ogrencino = txtogrencino.Text;
            guncelle.ogrencidogumtarih = dateTimePicker1.Value;
            guncelle.ogrencibolum = txtbolum.Text;
            guncelle.ogrencikayittarih = DateTime.Now;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Kayıdı Güncellendi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

       
       

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtogrencino_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtbolum_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
