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
    public partial class HastaBilgiEkleForm : Form
    {
        public HastaBilgiEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        SqlCommand komut;
        SqlDataAdapter bilgi;
        DataTable tablo = new DataTable();
        string sorgu;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        void hastalistele()
        {
          
            sorgu = "Select TCKimlik,AdiSoyadi,BabaAdi,AnneAdi,Uyruk,DogumYeri,DogumTarihi,Cinsiyet,SosyalGuvence,SosyalGuvenlikNo,MedeniDurum from HastaKimlikBilgi";
            bilgi = new SqlDataAdapter(sorgu, baglanti);
            bilgi.Fill(tablo);



        }

        private void HastaKimlikEkleForm_Load(object sender, EventArgs e)
        {
          
        }

        private void HastaKimlikEkleButon_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into HastaKimlikBilgi (TCKimlik,AdiSoyadi,BabaAdi,AnneAdi,Uyruk,DogumYeri,DogumTarihi,Cinsiyet,SosyalGuvence,SosyalGuvenlikNo,MedeniDurum) values (@TCKimlik,@AdiSoyadi,@BabaAdi,@AnneAdi,@Uyruk,@DogumYeri,@DogumTarihi,@Cinsiyet,@SosyalGuvence,@SosyalGuvenlikNo,@MedeniDurum)", baglanti);
                komut.Parameters.AddWithValue("@TCKimlik", textBox1.Text);
                komut.Parameters.AddWithValue("@AdiSoyadi", textBox2.Text);
                komut.Parameters.AddWithValue("@BabaAdi", textBox3.Text);
                komut.Parameters.AddWithValue("@AnneAdi", textBox4.Text);
                komut.Parameters.AddWithValue("@Uyruk", textBox5.Text);
                komut.Parameters.AddWithValue("@DogumYeri", textBox6.Text);
                komut.Parameters.AddWithValue("@DogumTarihi", Convert.ToDateTime(dateTimePicker1.Text));//textBox7.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                komut.Parameters.AddWithValue("@SosyalGuvence", comboBox2.Text);
                komut.Parameters.AddWithValue("@SosyalGuvenlikNo", textBox8.Text);
                komut.Parameters.AddWithValue("@MedeniDurum", comboBox3.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand idGetir = new SqlCommand("select HastaId from HastaKimlikBilgi where TCKimlik=@TCKimlik", baglanti);
                idGetir.Parameters.AddWithValue("@TCKimlik", textBox1.Text);
                SqlDataReader idReader = idGetir.ExecuteReader();
                int id = 0;
                while (idReader.Read())
                {
                    id = idReader.GetInt32(0);
                }
                baglanti.Close();

                HastaAdresKayit(id, textBox1.Text); 
                
                this.Close();

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void HastaAdresKayit(int hastaid, string HastaKimlikID)
        {
            try
            {
                baglanti.Open();
                SqlCommand komutt = new SqlCommand("insert into HastaAdresBilgi (hastaId,Sehir,İlce,Mahalle,CepTelefonu,CepTelefonu2,Email,HastaKimlikID) values (@hastaId,@Sehir,@İlce,@Mahalle,@CepTelefonu,@CepTelefonu2,@Email,@HastaKimlikID)", baglanti);
                komutt.Parameters.AddWithValue("@hastaId", hastaid);
                komutt.Parameters.AddWithValue("@Sehir", textBox9.Text);
                komutt.Parameters.AddWithValue("@İlce", textBox10.Text);
                komutt.Parameters.AddWithValue("@Mahalle", textBox11.Text);
                komutt.Parameters.AddWithValue("@CepTelefonu", textBox12.Text);
                komutt.Parameters.AddWithValue("@CepTelefonu2", textBox13.Text);
                komutt.Parameters.AddWithValue("@Email", textBox14.Text);
                komutt.Parameters.AddWithValue("@HastaKimlikID", HastaKimlikID);

                komutt.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
         
        }

        private void HastaBilgiEkleForm_Load(object sender, EventArgs e)
        {
            HastaKabulForm dif = new HastaKabulForm();
            dif.hastalistele();
        }
    }
}
