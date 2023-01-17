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
    public partial class okulyönetimekran : Form
    {
        public okulyönetimekran()
        {
            InitializeComponent();
        }

        iremdbEntities db = new iremdbEntities();
        public string deger;

        
        

      



        private void btnkaydet_Click(object sender, EventArgs e)
        {
            okulyonetimtablo ekle = new okulyonetimtablo();
            ekle.yonetimadsoyad = txtadsoyad.Text;
            ekle.yonetimgorevi = txtgorev.Text;


            if (cmbpozisyon.Text == "İdare")
            {
                ekle.yonetimtipi = "11";
            }
            else if (cmbpozisyon.Text == "Öğretmen")
            {
                ekle.yonetimtipi = "12";
            }
            else if (cmbpozisyon.Text == "Öğrenci İşleri")
            {
                ekle.yonetimtipi = "13";
            }


            db.okulyonetimtablo.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Yönetim Kaydı Oluşturuldu.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

     

      

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            btnkaydet.Enabled = true;
            int YonetimID = Convert.ToInt32(txtid.Text);

            var guncelle = db.okulyonetimtablo.Find(YonetimID);
            guncelle.yonetimadsoyad = txtadsoyad.Text;
            guncelle.yonetimgorevi = txtgorev.Text;
            if (label8.Text == "İdare")
            {
                guncelle.yonetimtipi = "11";
            }
            else if (label8.Text == "Öğretmen")
            {
                guncelle.yonetimtipi = "12";
            }
            else if (label8.Text == "Öğrenci İşleri")
            {
                guncelle.yonetimtipi = "13";
            }


            db.SaveChanges();
            MessageBox.Show("Yönetim Kayıdı Güncellendi", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void cmbpozisyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            label8.Text = cmbpozisyon.Text;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
