using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace pentasOtoparkOtomasyon
{
    public partial class Anasayfa : Form
    {
        public static int kulanici;

        public Anasayfa(int kulID)
        {
            InitializeComponent();
            kulanici = kulID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            odemeEkranı ode = new odemeEkranı(kulanici);
            ode.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ciro ciroekrani = new Ciro(kulanici);
            ciroekrani.Show();
            this.Hide();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

           
        }
    }

