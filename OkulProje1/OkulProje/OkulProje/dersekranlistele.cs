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
    public partial class dersekranlistele : Form
    {
        public dersekranlistele()
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

        private void dersekranlistele_Load(object sender, EventArgs e)
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

        
        }
    }

