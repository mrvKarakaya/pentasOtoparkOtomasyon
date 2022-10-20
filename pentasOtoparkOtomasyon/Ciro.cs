using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pentasOtoparkOtomasyon
{
    public partial class Ciro : Form
    {
        public static int kulanici;
        
        Fonksiyon system = new Fonksiyon();
        public Ciro(int kulID)
        {
            InitializeComponent();

            lblToplam.Width = 250;

            kulanici = kulID;

            
            string gun = DateTime.Now.ToString("dd.MM.yyyy");

            DataTable vtdb = system.GetDataTable("SELECT M.plaka, M.tarih," +
              " O.otoparkAdi, M.ucret, K.adSoyad," +

         " T.musteriTuru   FROM musteriler M INNER JOIN kullanicilar K ON M.kullaniciD = K.kullaniciID" +

              " INNER JOIN otoparklar O ON  M.otoparkID = O.otoparkID" +

           "   INNER JOIN tur T ON  M.turID = T.turID WHERE M.tarih>='" +gun+"' AND K.kullaniciID = " + kulanici);

            dataGridViewVeriler.DataSource = vtdb;
            lblToplam.Text = system.GetDataCell("SELECT Sum(ucret) AS toplam FROM musteriler M INNER JOIN kullanicilar K ON M.kullaniciD = K.kullaniciID WHERE M.tarih>='" + gun + "' AND K.kullaniciID = " + kulanici);
            lblToplam.Text += " TL";
        
        
        }
           
       
        private void Ciro_Load(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Anasayfa gitAnasayfa = new Anasayfa(kulanici);
            gitAnasayfa.Show();
            this.Hide();
        }
    }
}
