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
    public partial class Login : Form
    {
        public static int kulID=0;
        Fonksiyon db = new Fonksiyon();
        public Login()
        {
            InitializeComponent();
            

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DataRow dr = db.GetDataRow("SELECT * FROM kullanicilar WHERE email='"
                + txtEmail.Text + "' AND sifre='" + txtSifre.Text + "'"  );

            
            if (dr == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifreyi hatalı girdiniz.");

            }

            else
            {
                
                int yetki =Convert.ToInt32(dr["yetki"]);
                int ID = Convert.ToInt32(dr["kullaniciID"]);
                lblKullaniciID.Text = ID.ToString();
                kulID = Convert.ToInt32(dr["kullaniciID"]); 

                if (yetki==1)
                {
                    Anasayfa gitAnasayfa = new Anasayfa(kulID);
                    gitAnasayfa.Show();
                    this.Hide();
                }

                else
                {
                    YoneticiEkrani yonet = new YoneticiEkrani();
                    yonet.Show();
                    this.Hide();

                }
                
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

    
        private void Login_Load(object sender, EventArgs e)
        {
           
            
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSifre_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
