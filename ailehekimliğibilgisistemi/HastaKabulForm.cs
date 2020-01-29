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
    public partial class HastaKabulForm : Form
    {
        public HastaKabulForm()
        {
            InitializeComponent();
        }


        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
       
     
        SqlDataAdapter bilgi;
        SqlDataAdapter bilgii;
        DataTable tablo = new DataTable();
       
        SqlCommand komut;
        string sorgu;
        string sorgum;


        private void HastaKabulForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ahbsdatabaseDataSet1.HastaKimlikBilgi' table. You can move, or remove it, as needed.
            //this.hastaKimlikBilgiTableAdapter.Fill(this.ahbsdatabaseDataSet1.HastaKimlikBilgi);
            // TODO: This line of code loads data into the 'ahbsdatabaseDataSet.HastaAdresBilgi' table. You can move, or remove it, as needed.
            //this.hastaAdresBilgiTableAdapter.Fill(this.ahbsdatabaseDataSet.HastaAdresBilgi);
            hastalistele();
        }

        private void SilButon_Click(object sender, EventArgs e)
        {
            HastaSilFonksiyonu(comboBox1.Text, textBox1.Text);
           
            HastaKabulForm ob = new HastaKabulForm();
            ob.hastalistele();
            hastalistele();
        }

        private void Arama_Click(object sender, EventArgs e)
        {
            hastaAra(comboBox1.Text);
        }

        private void ekle_Click(object sender, EventArgs e)
        {
           
            HastaBilgiEkleForm ob = new HastaBilgiEkleForm();
            ob.ShowDialog();
            hastalistele();
        }


        void hastaAra(string parameter)

        {
            baglantı.Open();
            baglantı = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
            komut = new SqlCommand();
            tablo = new DataTable();
            komut.CommandText = ("SELECT * FROM HastaKimlikBilgi WHERE TCKimlik LIKE '%" + textBox1.Text.Trim() + "%' or AdiSoyadi LIKE '%" + textBox1.Text.Trim() + "%'or BabaAdi LIKE '%" + textBox1.Text.Trim() + "%'or AnneAdi LIKE '%" + textBox1.Text.Trim() + "%'or Uyruk LIKE '%" + textBox1.Text.Trim() + "%'or DogumYeri LIKE '%" + textBox1.Text.Trim() + "%'or DogumTarihi LIKE '%" + textBox1.Text.Trim() + "%'or Cinsiyet LIKE '%" + textBox1.Text.Trim() + "%'or SosyalGuvence LIKE '%" + textBox1.Text.Trim() + "%'or SosyalGuvenlikNo LIKE '%" + textBox1.Text.Trim() + "%'or MedeniDurum LIKE '%" + textBox1.Text.Trim() + "%' ");
            komut.Connection = baglantı;
            bilgi = new SqlDataAdapter(komut);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

      public  void hastalistele()
        {
            tablo.Clear();
            baglantı.Open();
            sorgu = "Select TCKimlik,AdiSoyadi,BabaAdi,AnneAdi,Uyruk,DogumYeri,DogumTarihi,Cinsiyet,SosyalGuvence,SosyalGuvenlikNo,MedeniDurum from HastaKimlikBilgi"; 
            bilgi = new SqlDataAdapter(sorgu, baglantı);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglantı.Close();

            
            //baglantı.Open();
            //sorgum = "Select * from HastaAdresBilgi";
            //bilgii = new SqlDataAdapter(sorgum, baglantı);
            //bilgii.Fill(tablo);
            //dataGridView2.DataSource = tablo;
            //baglantı.Close();

        }

        void HastaSilFonksiyonu(string kolonAdi, string kolonDegeri)
        {
            baglantı.Open();
            string tcno = dataGridView1.SelectedCells[0].Value.ToString();
            SqlCommand cmd = new SqlCommand("select HastaId from HastaKimlikBilgi where TCKimlik=@TCKimlik", baglantı);
            cmd.Parameters.AddWithValue("@TCKimlik", tcno);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            baglantı.Close();
            kisiadressil(id);
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from HastaKimlikBilgi where HastaId='"+ id + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }
        void kisiadressil(int adresid)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("delete from HastaAdresBilgi where hastaId='" + adresid + "'", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //muaynekartı
            string tcno = dataGridView1.SelectedCells[0].Value.ToString();
            string adisoyadi = dataGridView1.SelectedCells[1].Value.ToString();
            MuayeneForm MuayeneForm = new MuayeneForm();
            MuayeneForm.textBox1.Text = tcno;
            MuayeneForm.hastatcno = tcno;
            MuayeneForm.textBox2.Text = adisoyadi;
            MuayeneForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tcno = dataGridView1.SelectedCells[0].Value.ToString();
            string adisoyadi = dataGridView1.SelectedCells[1].Value.ToString();
            MuayeneForm MuayeneForm = new MuayeneForm();
            MuayeneForm.textBox1.Text = tcno;
            MuayeneForm.textBox2.Text = adisoyadi;
            MuayeneForm.ShowDialog();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            string tcno = dataGridView1.SelectedCells[0].Value.ToString();


            baglantı.Open();

            SqlDataAdapter bilgii;
            DataTable tabloo = new DataTable();
            string sorgum;

            //string tcNo = dataGridView1.CurrentRow.Cells["TCKimlik"].Value.ToString();
            SqlCommand cmd = new SqlCommand("select HastaId from HastaKimlikBilgi where TCKimlik=@TCKimlik",baglantı);
            cmd.Parameters.AddWithValue("@TCKimlik", tcno);
            SqlDataReader dr = cmd.ExecuteReader();
            int id = 0;
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
            baglantı.Close();

            sorgum = "Select Sehir,İlce,Mahalle,CepTelefonu,CepTelefonu2,Email from HastaAdresBilgi where hastaId='" + id + "'";
            bilgii = new SqlDataAdapter(sorgum, baglantı);
            bilgii.Fill(tabloo);
            dataGridView2.DataSource = tabloo;
            baglantı.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
