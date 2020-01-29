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
    public partial class MuayeneFormIstem : Form
    {
        public static DataTable secilenistemler = new DataTable();
        public MuayeneFormIstem()
        {
            InitializeComponent();
        }

        public object SqlDateReader { get; private set; }
        SqlConnection baglantı = new SqlConnection(" Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");
        SqlDataAdapter bilgi;
        DataTable tablo = new DataTable();
        SqlCommand komut;
        string sorgu;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        void istemlistele()
        {
            tablo.Clear();
            sorgu = "select Istem,Kodu from MuayeneIstemGenel";
            bilgi = new SqlDataAdapter(sorgu, baglantı);
            bilgi.Fill(tablo);
            dataGridView1.DataSource = tablo;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MuayeneFormIstem_Load(object sender, EventArgs e)
        {
            istemlistele();
            if (secilenistemler.Columns.Count > 0)
            {

            }
            else
            {
                secilenistemler.Columns.Add("Kod");
                secilenistemler.Columns.Add("İstem");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value.ToString() != "")
            {
                string Kodu = dataGridView1.SelectedCells[0].Value.ToString();
                string Tani = dataGridView1.SelectedCells[1].Value.ToString();

                secilenistemler.Rows.Add(Kodu, Tani);
                dataGridView2.DataSource = secilenistemler;

            }
            else
            {
                MessageBox.Show(" İstem Seçiniz !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("Select * from muayeneIstemGenel where Istem like '%" + textBox1.Text + "%'", baglantı);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglantı.Close();
            textBox1.Clear();
        }
    }
}
