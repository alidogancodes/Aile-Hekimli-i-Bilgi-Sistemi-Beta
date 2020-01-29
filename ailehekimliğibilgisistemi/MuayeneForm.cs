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
    public partial class MuayeneForm : Form
    {
        public MuayeneForm()
        {
            InitializeComponent();
        }
        public MuayeneForm(string _hastatcno)
        {
            hastatcno = _hastatcno;
            InitializeComponent();
        }
        public static string hastatcno;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        SqlCommand komut;
        SqlDataAdapter bilgi;
        DataTable tablo = new DataTable();
        string sorgu;
        string sorgum;

        void Muayenelistele()
        {
            try
            {

                baglanti.Open();
                tablo.Clear();
                sorgum = "Select TCKimlik,AdıSoyadı,Ateş,Nabız,Şikayet,KüçükTansiyon,BüyükTansiyon,Solunum,MuayeneID from MuayeneFormGenelBilgi where TCKimlik = '" +hastatcno.ToString()+ "'";
                bilgi = new SqlDataAdapter(sorgum, baglanti);
                bilgi.Fill(tablo);
                dataGridView2.DataSource = tablo;
                baglanti.Close();



                dataGridView1.DataSource = tablo;
                baglanti.Close();
            }
            catch (Exception ex)
            {
                string mesaj = ex.Message.ToString();
            }
          



        }
        public void secilenilaclarlistele()
        {

            if (MuayeneFormIlac.secilenilaclar.Rows.Count > 0)
            {
                dataGridView3.DataSource = MuayeneFormIlac.secilenilaclar;
            }

        }
        

            public void secilentanilistele()
        {

            if (MuayeneFormTanı.secilentanılar.Rows.Count > 0)
            {
                dataGridView2.DataSource = MuayeneFormTanı.secilentanılar;
            }

        }
        public void secilenistemlistele()
        {

            if (MuayeneFormIstem.secilenistemler.Rows.Count > 0)
            {
                dataGridView4.DataSource = MuayeneFormIstem.secilenistemler;
            }

        }
        public void MuayeneForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.Bounds.Location;
            Muayenelistele();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MuayeneFormIlac dif = new MuayeneFormIlac();
            dif.ShowDialog();
            

                secilenilaclarlistele();
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HastaKabulForm dif = new HastaKabulForm();
            dif.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MuayeneFormTanı dif = new MuayeneFormTanı();
            dif.ShowDialog();
            secilentanilistele();
            



        }

        private void button5_Click(object sender, EventArgs e)
        {
            MuayeneFormIstem dif = new MuayeneFormIstem();
            dif.ShowDialog();
            secilenistemlistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into MuayeneFormGenelBilgi ( TCKimlik,AdıSoyadı,Ateş,Nabız,Şikayet,KüçükTansiyon,BüyükTansiyon,Solunum) values (@TCKimlik,@AdıSoyadı,@Ateş,@Nabız,@Şikayet,@KüçükTansiyon,@BüyükTansiyon,@Solunum) SELECT SCOPE_IDENTITY()", baglanti);
                komut.Parameters.AddWithValue("@TCKimlik", textBox1.Text);
                komut.Parameters.AddWithValue("@AdıSoyadı", textBox2.Text);
                //komut.Parameters.AddWithValue("@Doktor", Text);
                komut.Parameters.AddWithValue("@Ateş", textBox3.Text);
                komut.Parameters.AddWithValue("@Nabız", textBox4.Text);
                komut.Parameters.AddWithValue("@Şikayet", textBox8.Text);
                komut.Parameters.AddWithValue("@KüçükTansiyon", textBox5.Text);
                komut.Parameters.AddWithValue("@BüyükTansiyon", textBox6.Text);
                komut.Parameters.AddWithValue("@Solunum", textBox7.Text);
                //komut.Parameters.AddWithValue("@MuayeneID", textBox8.Text);
                String idno = komut.ExecuteScalar().ToString();
                baglanti.Close();

                int muayene_id = Convert.ToInt32(idno)+ 1;
                foreach (DataRow drilaclar in MuayeneFormIlac.secilenilaclar.Rows)
                {

                    baglanti.Open();
                    SqlCommand komutt = new SqlCommand("insert into MuayeneIlaclar( IlacAdi,Firma,Adet,MuayeneID,KODU) values (@IlacAdi,@Firma,@Adet,@MuayeneID,@KODU)", baglanti);
                    komutt.Parameters.AddWithValue("@IlacAdi", drilaclar["Adı"].ToString()); 
                    komutt.Parameters.AddWithValue("@Firma", DBNull.Value);
                    komutt.Parameters.AddWithValue("@Adet", DBNull.Value);
                    komutt.Parameters.AddWithValue("@MuayeneID", muayene_id);
                    komutt.Parameters.AddWithValue("@KODU", drilaclar["Barkodu"].ToString());
                    komutt.ExecuteNonQuery();
                    baglanti.Close();


                }
                foreach (DataRow drtanilar in MuayeneFormTanı.secilentanılar.Rows)
                {

                    baglanti.Open();
                    SqlCommand komutt = new SqlCommand("insert into MuayeneTanı( TanıId,TanıAdı,Kodu,MuayeneID) values (@TanıId,@TanıAdı,@Kodu,@MuayeneID)", baglanti);
                    komutt.Parameters.AddWithValue("@TanıId", DBNull.Value);
                    komutt.Parameters.AddWithValue("@TanıAdı", drtanilar["Tanı"].ToString());
                    komutt.Parameters.AddWithValue("@Kodu", drtanilar["Kod"].ToString());
                    komutt.Parameters.AddWithValue("@MuayeneID", muayene_id);
                    komutt.ExecuteNonQuery();
                    baglanti.Close();


                }
                foreach (DataRow dristemler in MuayeneFormIstem.secilenistemler.Rows)
                {

                    baglanti.Open();
                    SqlCommand komutt = new SqlCommand("insert into MuayeneIstem( IstemId,Istem,Kodu,Adet,MuayeneID) values (@IstemId,@Istem,@Kodu,@Adet,@MuayeneID)", baglanti);
                    komutt.Parameters.AddWithValue("@IstemId", DBNull.Value);
                    komutt.Parameters.AddWithValue("@Istem", dristemler["Istem"].ToString());
                    komutt.Parameters.AddWithValue("@Kodu", dristemler["Kod"].ToString());
                    komutt.Parameters.AddWithValue("@Adet", DBNull.Value);
                    komutt.Parameters.AddWithValue("@MuayeneID", muayene_id);
                    komutt.ExecuteNonQuery();
                    baglanti.Close();


                }

                Muayenelistele();
            }
            catch (Exception ex)
            { MessageBox.Show("" + ex); }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
