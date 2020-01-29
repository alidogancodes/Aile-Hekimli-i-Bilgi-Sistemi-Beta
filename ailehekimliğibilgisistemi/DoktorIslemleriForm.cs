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
using System.Data.SqlClient;

namespace ailehekimliğibilgisistemi
{
    public partial class DoktorIslemleriForm : Form
    {
        public DoktorIslemleriForm()
        {
            InitializeComponent();
        }

        SqlConnection baglantı = new SqlConnection(" Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter bilgi;
        SqlDataAdapter bİlgii;
        DataTable tablo = new DataTable();
        string sorgu;
        string sorgum;



        private void SilButon_Click(object sender, EventArgs e)
        {
            DoktorSilFonksiyonu(comboBox1.Text, textBox1.Text);
            DoktorIslemleriForm ob = new DoktorIslemleriForm();
            ob.doktorlistele();

        }

       

        private void doktorislemleri_Load(object sender, EventArgs e)
        {


            doktorlistele();

        }






        private void Arama_Click(object sender, EventArgs e)
        {
            doktorAra(comboBox1.Text);
            //sorgu = "Select TCKimlik like +'%' from doktorBilgi";
            //bilgi = new SqlDataAdapter(sorgu, baglantı);
            //sorgu = "select * from doktorBilgi where TCKimlik like '%" + comboBox1.Text +"%' or Adi like ";
            //bilgi.Fill(tablo);
            //dataGridView1.DataSource = tablo;
            //dataGridView1.Show();
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
         
            DoktorEkleForm ob = new DoktorEkleForm();
            ob.ShowDialog();
            doktorlistele();

        }

      


        void doktorAra(string parameter)

        {
            baglantı.Open();
            baglantı = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
            komut = new SqlCommand();
            tablo = new DataTable();
            komut.CommandText = ("SELECT * FROM doktorBilgi WHERE TCKimlik LIKE '%" + textBox1.Text.Trim() + "%' or Adi LIKE '%" + textBox1.Text.Trim() + "%'or Soyadi LIKE '%" + textBox1.Text.Trim() + "%'or CepNumarasi LIKE '%" + textBox1.Text.Trim() + "%'or Email LIKE '%" + textBox1.Text.Trim() + "%' ");
            komut.Connection = baglantı;
            bilgi = new SqlDataAdapter(komut);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

       public void doktorlistele()
        {
            tablo.Clear();
            baglantı.Open();
            sorgu = "Select TCKimlik,Adi,Soyadi,CepNumarasi,Adres,Email from doktorBilgi";
            bilgi = new SqlDataAdapter(sorgu, baglantı);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();

        }

        void DoktorSilFonksiyonu(string kolonAdi, string kolonDegeri)
        {
           // if 
            //{

                string TCKimlik = dataGridView1.SelectedCells[0].Value.ToString();
                baglantı.Open();

                SqlDataAdapter bilgii;
                DataTable tabloo = new DataTable();
                string sorgum;
                SqlCommand komut = new SqlCommand("delete from doktorBilgi where TCKimlik ='" + TCKimlik + "'", baglantı);
                komut.ExecuteNonQuery();
            //}

            /*else
            {
                MessageBox.Show(" Silinecek herhangi bir değer bulunamadı.");
            }*/
            baglantı.Close();
                doktorlistele();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

