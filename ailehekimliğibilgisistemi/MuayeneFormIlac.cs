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
    public partial class MuayeneFormIlac : Form
    {

        public MuayeneFormIlac()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        SqlCommand komut;
        SqlDataAdapter bilgi;
        DataTable tablo = new DataTable();
        string sorgu;


        // public void ilacListele()
        /*{
            MuayeneForm.tablo.Clear();
            MuayeneForm.baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * From ilacbil", MuayeneForm.baglanti);
            adtr.Fill(MuayeneForm.tablo);
            dataGridView1.DataSource = MuayeneForm.tablo;
            adtr.Dispose();
            MuayeneForm.baglanti.Close();

        }*/

        public static DataTable secilenilaclar = new DataTable();
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            string Adi = dataGridView1.SelectedCells[0].Value.ToString();
            string Barkodu = dataGridView1.SelectedCells[1].Value.ToString();


            secilenilaclar.Rows.Add(Adi, Barkodu);
            dataGridView2.DataSource = secilenilaclar;
            //secilenilaclar.Rows.Add();
        }

        private void MuayeneFormIlac_Load(object sender, EventArgs e)
        {
            ilaclistele();
           // SepetListele();
            secilenilaclar.Columns.Add("Adı");
           secilenilaclar.Columns.Add("Barkodu");

        }

        void ilaclistele()
        {
            tablo.Clear();
            sorgu = " select ILAC_ADI,BARKODU,FIRMA_ADI from S_ILACLAR where AKTIF= 'True'";
            bilgi = new SqlDataAdapter(sorgu, baglanti);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }
        
        void SepetListele()
        {
            tablo.Clear();

            sorgu = "Select IlacAdi,Firma,Adet from MuayeneIlaclar";
            bilgi = new SqlDataAdapter(sorgu, baglanti);
            bilgi.Fill(tablo);
            dataGridView2.DataSource = tablo;



        }






        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {
           
            this.Close();

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from S_ILACLAR where ILAC_ADI like '%" + textBox1.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            textBox1.Clear();
        }
    }
}
