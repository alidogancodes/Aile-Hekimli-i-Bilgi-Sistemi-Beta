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
using System.Data.OleDb;

namespace ailehekimliğibilgisistemi
{
    public partial class DoktorEkleForm : Form
    {
        public DoktorEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        SqlCommand komut;
        SqlDataAdapter bilgi;
        SqlDataAdapter bİlgii;
        DataTable tablo = new DataTable();
        string sorgu;
        string sorgum;



        //void doktorlistele()
        //{
        //    //tablo.Clear();
        //    //tablo.Rows.Clear();
        //    sorgu = "Select TCKimlik,Adi,Soyadi,CepNumarasi,Adres,Email from doktorBilgi";
        //    bilgi = new SqlDataAdapter(sorgu, baglanti);
        //    bilgi.Fill(tablo);
        //    //DoktorIslemleriForm fasa = new DoktorIslemleriForm();
        //   // fasa.Refresh();
        //   // fasa.dataGridView1.Rows.Clear();
        //   //fasa.dataGridView1.DataSource = tablo;
            
            

        //}
       

        private void DoktorEkleForm_Load(object sender, EventArgs e)
        {
         
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      
        private void DoktorEkleButon_Click(object sender, EventArgs e)
        {    
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into doktorBilgi (TCKimlik,Adi,Soyadi,CepNumarasi,Adres,Email)values (@textBox1,@textBox2,@textBox3,@textBox4,@textBox5,@textBox6)", baglanti);
                komut.Parameters.AddWithValue("@textBox1", textBox1.Text);
                komut.Parameters.AddWithValue("@textBox2", textBox2.Text);
                komut.Parameters.AddWithValue("@textBox3", textBox3.Text);
                komut.Parameters.AddWithValue("@textBox4", textBox4.Text);
                komut.Parameters.AddWithValue("@textBox5", textBox5.Text);
                komut.Parameters.AddWithValue("@textBox6", textBox6.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                
                this.Close();
            }
            catch 
            {
            }
            

        }
        
    }
}
