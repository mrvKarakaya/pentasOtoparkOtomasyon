using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pentasOtoparkOtomasyon
{
    public partial class odemeEkranı : Form
    {

        public static int kulanici;
        Fonksiyon system = new Fonksiyon();
        public odemeEkranı(int kulID)
        {
            InitializeComponent();
            kulanici = kulID;
        }
      
        private void button11_Click(object sender, EventArgs e)

        {
            Anasayfa gitAnasayfa = new Anasayfa(kulanici);
            gitAnasayfa.Show();
            this.Hide();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            lblucretsiz.Visible = true;
            cmbucretsiz.Visible = true;
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
           /* if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();

            SqlCommand komut = new SqlCommand("musteriler", baglanti);
            komut.CommandType = CommandType.StoredProcedure;

            komut.Parameters.AddWithValue("@tc_kimlik", texttc.Text);
            komut.Parameters.AddWithValue("@ad", textad.Text);
            komut.Parameters.AddWithValue("@soyad", textsoyad.Text);
            komut.Parameters.AddWithValue("@cep_telefonu", texttelefon.Text);
            komut.Parameters.AddWithValue("@plaka_no", textplaka.Text);
            komut.Parameters.AddWithValue("@arac_marka", textmarka.Text);
            komut.Parameters.AddWithValue("@arac_renk", textrenk.Text);
            komut.Parameters.AddWithValue("@park_yeri", comboparkyeri.Text);
            komut.ExecuteNonQuery();*/
        }

       
        private void odemeEkranı_Load_1(object sender, EventArgs e)
        {


            DataTable dt = system.GetDataTable("SELECT * FROM Tur");
            cmbucretsiz.DataSource = dt;
            cmbucretsiz.ValueMember = "turID";
            cmbucretsiz.DisplayMember = "musteriTuru";
           
            txtSaat.Text = DateTime.Now.ToString("H:mm");
            
            txtTarih.Text = DateTime.Now.ToString("dd.MM.yyyy");



            txtUcret.Text = system.GetDataCell("SELECT  O.ucret FROM kullanicilar K INNER JOIN otoparklar O ON  K.otoparkID = O.otoparkID  WHERE K.kullaniciID = " + kulanici);
            lblOtoparkİsim.Text = system.GetDataCell("SELECT O.otoparkAdi FROM kullanicilar K INNER JOIN otoparklar O ON  K.otoparkID = O.otoparkID  WHERE K.kullaniciID = " + kulanici );

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCıkıs_Click_1(object sender, EventArgs e)

        {
            string otoparkID = system.GetDataCell("SELECT  O.otoparkID FROM kullanicilar K INNER JOIN otoparklar O ON  K.otoparkID = O.otoparkID  WHERE K.kullaniciID = " + kulanici);
            DateTime zamann = DateTime.Now;
            string zaman = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            int turid = (int)cmbucretsiz.SelectedValue;

            //system.cmd("INSERT INTO musteriler(otoparkID, ucret, turID, plaka, tarih, kullaniciD) VALUES(" + otoparkID + ", " + txtUcret.Text + "," + turid + ", '" + txtPlaka.Text + "', '" + zamann + "', " + kulanici + ")");

            if (txtPlaka.Text == "" && cmbucretsiz.SelectedIndex != 0)
            {
                MessageBox.Show("Ücretsiz Geçişte Plakayı Boş Geçemezsiniz", "Boş Alan Hatası");
            }

            else {

                system.cmd("INSERT INTO musteriler(otoparkID, ucret, turID, plaka, tarih, kullaniciD) VALUES(" + otoparkID + ", " + txtUcret.Text + "," + turid + ", '" + txtPlaka.Text + "', '" + zaman + "', " + kulanici + ")");
                //DialogResult dialogResult = MessageBox.Show("Çıkış işlemi tamamlanmıştır.", "", MessageBoxButtons.OK);
                MessageBox.Show("Çıkış işlemi tamamlanmıştır.", "ÇIKIŞ ONAYLANDI");
                Anasayfa gitAnasayfa = new Anasayfa(kulanici);
                gitAnasayfa.Show();
                this.Hide();


            }

        }

        private void cmbucretsiz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbucretsiz.SelectedIndex != 0 )
            {

                txtUcret.Text = "0";
                txtPlaka.Visible = true;
                lblPlaka.Visible = true;
             


            }
            else

            {
                txtPlaka.Visible = false;
                lblPlaka.Visible = false;

            }
        }

        private void txtTarih_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlaka_TextChanged(object sender, EventArgs e)
        {
            txtPlaka.CharacterCasing = CharacterCasing.Upper;
        }
    }
}
