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

namespace ailehekimliğibilgisistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {


            baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from giris_sayfasi where kullaniciadi= '" + textBox1.Text + "' and sifre = '" + textBox2.Text + "'", baglantı);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Form2 frm2 = new Form2();
                frm2.Show();
                this.Hide();
                dr.Close();
            }
            else
            {
                MessageBox.Show(" Kullanıcı Adı veya Şifre Hatalıdır. Lütfen Tekrar Deneyiniz.");
            }
            baglantı.Close();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                //checkBox işaretli ise
                if (checkBox1.Checked)
                {
                    //karakteri göster.
                    textBox2.PasswordChar ='*' ;
                   
                }
                //değilse karakterlerin yerine * koy.
                else
                {
                    textBox2.PasswordChar = '\0';
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }

}