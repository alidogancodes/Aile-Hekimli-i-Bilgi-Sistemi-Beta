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
    public partial class Form2 : Form
    {
        public Form1 frm1;
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-HJ8M3QQ;Initial Catalog=ahbsdatabase;Integrated Security=True");

        public object SqlDateReader { get; private set; }

        private void Muayene_Click(object sender, EventArgs e)
        {
            MuayeneForm ob = new MuayeneForm();
            ob.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

              DoktorIslemleri();
              HastaIslemleri();
            MuayeneIslemleri();
            CıkısIslemleri();

       
            }
        public void CıkısIslemleri()
        {
            CloseForm ob = new CloseForm();

            ob.TopLevel = false;

            ob.Dock = DockStyle.Fill;

            ob.FormBorderStyle = FormBorderStyle.None;
            tabPage4.Controls.Add(ob);
            ob.Show();

           // close2 CLS = new close2();
           // CLS.
            
        
        }
        public void DoktorIslemleri()
        {
            DoktorIslemleriForm ob = new DoktorIslemleriForm();

            ob.TopLevel = false;

            ob.Dock = DockStyle.Fill;

            ob.FormBorderStyle = FormBorderStyle.None;
            tabPage1.Controls.Add(ob);
            ob.Show();
        }

        public void HastaIslemleri()
        {
            HastaKabulForm ob = new HastaKabulForm();

            ob.TopLevel = false;

            ob.Dock = DockStyle.Fill;

            ob.FormBorderStyle = FormBorderStyle.None;
            tabPage2.Controls.Add(ob);
            //toolStripButton1.
            ob.Show();
        }

        public void MuayeneIslemleri()
        {
            MuayeneForm ob = new MuayeneForm();

            ob.TopLevel = false;

            ob.Dock = DockStyle.Fill;

            ob.FormBorderStyle = FormBorderStyle.None;
            tabPage3.Controls.Add(ob);
            ob.Show();
        }
        private void doktorislemleri_Click(object sender, EventArgs e)
        {

          
            DoktorIslemleriForm ob = new DoktorIslemleriForm();
            ob.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HastaBilgisiForm ob = new HastaBilgisiForm();
            ob.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HastaKabulForm ob = new HastaKabulForm();
            ob.ShowDialog();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }
    }
}
