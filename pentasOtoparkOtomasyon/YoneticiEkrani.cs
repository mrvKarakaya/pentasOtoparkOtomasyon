using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pentasOtoparkOtomasyon
{
    public partial class YoneticiEkrani : Form
    {
        //Fonksiyon dtbase = new Fonksiyon();
        Fonksiyon system = new Fonksiyon();

        public YoneticiEkrani()
        {
            InitializeComponent();

            DataTable dtbs = system.GetDataTable("SELECT M.plaka, M.tarih," +
             " O.otoparkAdi, O.ucret, K.adSoyad," +

        " T.musteriTuru   FROM musteriler M INNER JOIN kullanicilar K ON M.kullaniciD = K.kullaniciID" +

             " INNER JOIN otoparklar O ON  M.otoparkID = O.otoparkID" +

           "   INNER JOIN tur T ON  M.turID = T.turID");

            dataGridView1.DataSource = dtbs;



        }
        
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* if (cmbOtopark.SelectedIndex == 0)

             {
                 DataTable dtbs = system.GetDataTable("SELECT*from musteriler where otoparkID=1");
                 dataGridView1.DataSource = dtbs;
             }

             else if (cmbOtopark.SelectedIndex == 1)

             {
                 DataTable dtbs = system.GetDataTable("SELECT*from musteriler where otoparkID=2");
                 dataGridView1.DataSource = dtbs;

             }
             else if (cmbOtopark.SelectedIndex == 2)

             {
                 DataTable dtbs = system.GetDataTable("SELECT*from musteriler where otoparkID=3");
                 dataGridView1.DataSource = dtbs;

             }*/

        }

        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {

            DataTable dt = system.GetDataTable("SELECT * FROM otoparklar");
            cmbOtopark.DataSource = dt;
            cmbOtopark.ValueMember = "otoparkID";
            cmbOtopark.DisplayMember ="otoparkAdi";

            DataTable dt1 = system.GetDataTable("SELECT * FROM kullanicilar");
            cmbGorevli.DataSource = dt1;
            cmbGorevli.ValueMember = "kullaniciID";
            cmbGorevli.DisplayMember = "adSoyad";

            DataTable dt2 = system.GetDataTable("SELECT * FROM Tur");
            cmbTur.DataSource = dt2;
            cmbTur.ValueMember = "turID";
            cmbTur.DisplayMember = "musteriTuru";

            DataTable dt3 = system.GetDataTable("SELECT * FROM musteriler");
            cmbTarih.DataSource = dt3;
            cmbTarih.ValueMember = "musteriID";
            cmbTarih.DisplayMember = "tarih";



           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbGorevli.Text = " ";
            cmbOtopark.Text = " ";
            cmbTarih.Text = " ";
            cmbTur.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }


   
}