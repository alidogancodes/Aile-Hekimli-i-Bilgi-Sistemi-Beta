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
    public partial class MuayeneFormTanı : Form
    {

        public static DataTable secilentanılar = new DataTable();
        public MuayeneFormTanı()
        {
            InitializeComponent();
        }
        public object SqlDateReader { get; private set; }
        SqlConnection baglantı = new SqlConnection(" Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
        SqlDataAdapter bilgi;
        DataTable tablo = new DataTable();
        SqlCommand komut;
        string sorgu;

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value.ToString() != "")
            {
                string Kodu = dataGridView1.SelectedCells[0].Value.ToString();
                string Tani = dataGridView1.SelectedCells[1].Value.ToString();

                secilentanılar.Rows.Add(Kodu, Tani);
                dataGridView2.DataSource = secilentanılar;

            }
            else
            {
                MessageBox.Show(" Tanı Seçiniz !");
            }
        }

       /* private void MuayeneFormTanı_Load(object sender, EventArgs e)
        {
            tanilistele();
            secilentanılar.Columns.Add("Adı");
            secilentanılar.Columns.Add(" Barkodu");
        }*/
        void tanilistele()
        {
            tablo.Clear();
            sorgu = "select ICD10_KODU,ICD10_ADI from S_ICD10";
            bilgi = new SqlDataAdapter(sorgu, baglantı);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuayeneFormTanı_Load_1(object sender, EventArgs e)
        {
            tanilistele();
            if (secilentanılar.Columns.Count > 0)
            {

            }
            else
            {
                secilentanılar.Columns.Add("Kod");
                secilentanılar.Columns.Add("Tanı");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from S_ICD10 where ICD10_ADI like '%" + textBox1.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            textBox1.Clear();
        }
    }
}
