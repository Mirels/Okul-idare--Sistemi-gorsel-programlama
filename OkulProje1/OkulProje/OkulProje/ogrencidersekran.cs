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
    public partial class ogrencidersekran : Form
    {
        public ogrencidersekran()
        {
            InitializeComponent();
        }

        iremdbEntities db = new iremdbEntities();

       


      


        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciderstablo ekle = new ogrenciderstablo();
            ekle.ogrencidersdersid = Convert.ToInt16(cmbders.SelectedValue);
            ekle.ogrencidersogrenciid = Convert.ToInt16(cmbogrenci.SelectedValue);
            db.ogrenciderstablo.Add(ekle);
            db.SaveChanges();
            MessageBox.Show("Öğrenciye Ders Ataması Yapıldı.", "Sistem Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void cmbders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbogrenci_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

   

        

       

      

     
 

    }

