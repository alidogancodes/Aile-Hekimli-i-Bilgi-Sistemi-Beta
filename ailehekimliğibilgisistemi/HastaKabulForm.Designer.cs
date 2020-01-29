namespace ailehekimliğibilgisistemi
{
    partial class HastaKabulForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaKabulForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tCKimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiSoyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anneAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uyrukDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumYeriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doğumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosyalGüvenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sosyalGüvenlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medeniDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaKimlikBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ahbsdatabaseDataSet1 = new ailehekimliğibilgisistemi.ahbsdatabaseDataSet1();
            this.SilButon = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Arama = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.hastaAdresBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ahbsdatabaseDataSet = new ailehekimliğibilgisistemi.ahbsdatabaseDataSet();
            this.hastaAdresBilgiTableAdapter = new ailehekimliğibilgisistemi.ahbsdatabaseDataSetTableAdapters.HastaAdresBilgiTableAdapter();
            this.hastaKimlikBilgiTableAdapter = new ailehekimliğibilgisistemi.ahbsdatabaseDataSet1TableAdapters.HastaKimlikBilgiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKimlikBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahbsdatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaAdresBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahbsdatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tCKimlikDataGridViewTextBoxColumn,
            this.adiSoyadiDataGridViewTextBoxColumn,
            this.babaAdiDataGridViewTextBoxColumn,
            this.anneAdiDataGridViewTextBoxColumn,
            this.uyrukDataGridViewTextBoxColumn,
            this.doğumYeriDataGridViewTextBoxColumn,
            this.doğumTarihiDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.sosyalGüvenceDataGridViewTextBoxColumn,
            this.sosyalGüvenlikNoDataGridViewTextBoxColumn,
            this.medeniDurumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hastaKimlikBilgiBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.Location = new System.Drawing.Point(21, 47);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1457, 303);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // tCKimlikDataGridViewTextBoxColumn
            // 
            this.tCKimlikDataGridViewTextBoxColumn.DataPropertyName = "TCKimlik";
            this.tCKimlikDataGridViewTextBoxColumn.HeaderText = "TCKimlik";
            this.tCKimlikDataGridViewTextBoxColumn.Name = "tCKimlikDataGridViewTextBoxColumn";
            // 
            // adiSoyadiDataGridViewTextBoxColumn
            // 
            this.adiSoyadiDataGridViewTextBoxColumn.DataPropertyName = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.HeaderText = "AdiSoyadi";
            this.adiSoyadiDataGridViewTextBoxColumn.Name = "adiSoyadiDataGridViewTextBoxColumn";
            // 
            // babaAdiDataGridViewTextBoxColumn
            // 
            this.babaAdiDataGridViewTextBoxColumn.DataPropertyName = "BabaAdi";
            this.babaAdiDataGridViewTextBoxColumn.HeaderText = "BabaAdi";
            this.babaAdiDataGridViewTextBoxColumn.Name = "babaAdiDataGridViewTextBoxColumn";
            // 
            // anneAdiDataGridViewTextBoxColumn
            // 
            this.anneAdiDataGridViewTextBoxColumn.DataPropertyName = "AnneAdi";
            this.anneAdiDataGridViewTextBoxColumn.HeaderText = "AnneAdi";
            this.anneAdiDataGridViewTextBoxColumn.Name = "anneAdiDataGridViewTextBoxColumn";
            // 
            // uyrukDataGridViewTextBoxColumn
            // 
            this.uyrukDataGridViewTextBoxColumn.DataPropertyName = "Uyruk";
            this.uyrukDataGridViewTextBoxColumn.HeaderText = "Uyruk";
            this.uyrukDataGridViewTextBoxColumn.Name = "uyrukDataGridViewTextBoxColumn";
            // 
            // doğumYeriDataGridViewTextBoxColumn
            // 
            this.doğumYeriDataGridViewTextBoxColumn.DataPropertyName = "DoğumYeri";
            this.doğumYeriDataGridViewTextBoxColumn.HeaderText = "DoğumYeri";
            this.doğumYeriDataGridViewTextBoxColumn.Name = "doğumYeriDataGridViewTextBoxColumn";
            // 
            // doğumTarihiDataGridViewTextBoxColumn
            // 
            this.doğumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.HeaderText = "DoğumTarihi";
            this.doğumTarihiDataGridViewTextBoxColumn.Name = "doğumTarihiDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // sosyalGüvenceDataGridViewTextBoxColumn
            // 
            this.sosyalGüvenceDataGridViewTextBoxColumn.DataPropertyName = "SosyalGüvence";
            this.sosyalGüvenceDataGridViewTextBoxColumn.HeaderText = "SosyalGüvence";
            this.sosyalGüvenceDataGridViewTextBoxColumn.Name = "sosyalGüvenceDataGridViewTextBoxColumn";
            // 
            // sosyalGüvenlikNoDataGridViewTextBoxColumn
            // 
            this.sosyalGüvenlikNoDataGridViewTextBoxColumn.DataPropertyName = "SosyalGüvenlikNo";
            this.sosyalGüvenlikNoDataGridViewTextBoxColumn.HeaderText = "SosyalGüvenlikNo";
            this.sosyalGüvenlikNoDataGridViewTextBoxColumn.Name = "sosyalGüvenlikNoDataGridViewTextBoxColumn";
            // 
            // medeniDurumDataGridViewTextBoxColumn
            // 
            this.medeniDurumDataGridViewTextBoxColumn.DataPropertyName = "MedeniDurum";
            this.medeniDurumDataGridViewTextBoxColumn.HeaderText = "MedeniDurum";
            this.medeniDurumDataGridViewTextBoxColumn.Name = "medeniDurumDataGridViewTextBoxColumn";
            // 
            // hastaKimlikBilgiBindingSource
            // 
            this.hastaKimlikBilgiBindingSource.DataMember = "HastaKimlikBilgi";
            this.hastaKimlikBilgiBindingSource.DataSource = this.ahbsdatabaseDataSet1;
            // 
            // ahbsdatabaseDataSet1
            // 
            this.ahbsdatabaseDataSet1.DataSetName = "ahbsdatabaseDataSet1";
            this.ahbsdatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SilButon
            // 
            this.SilButon.Location = new System.Drawing.Point(1341, 570);
            this.SilButon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SilButon.Name = "SilButon";
            this.SilButon.Size = new System.Drawing.Size(109, 57);
            this.SilButon.TabIndex = 14;
            this.SilButon.Text = "Sil";
            this.SilButon.UseVisualStyleBackColor = true;
            this.SilButon.Click += new System.EventHandler(this.SilButon_Click);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(1341, 494);
            this.ekle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(108, 57);
            this.ekle.TabIndex = 13;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 494);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Bilgi Girişi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(922, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bilgi Türü";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(925, 515);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 27);
            this.textBox1.TabIndex = 10;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "TCKimlik",
            "Adı Soyadı",
            "BabaAdi",
            "AnneAdi",
            "Uyruk",
            "DoğumYeri",
            "DoğumTarihi",
            "Cinsiyet",
            "SosyalGüvenlikNo",
            "MedeniDurum"});
            this.comboBox1.Location = new System.Drawing.Point(925, 442);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(363, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // Arama
            // 
            this.Arama.Location = new System.Drawing.Point(1341, 413);
            this.Arama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Arama.Name = "Arama";
            this.Arama.Size = new System.Drawing.Size(107, 57);
            this.Arama.TabIndex = 8;
            this.Arama.Text = "Ara";
            this.Arama.UseVisualStyleBackColor = true;
            this.Arama.Click += new System.EventHandler(this.Arama_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hasta Kimlik Bilgisi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 366);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Hasta İletişim Bilgisi";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(21, 385);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(860, 279);
            this.dataGridView2.TabIndex = 18;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // hastaAdresBilgiBindingSource
            // 
            this.hastaAdresBilgiBindingSource.DataMember = "HastaAdresBilgi";
            this.hastaAdresBilgiBindingSource.DataSource = this.ahbsdatabaseDataSet;
            // 
            // ahbsdatabaseDataSet
            // 
            this.ahbsdatabaseDataSet.DataSetName = "ahbsdatabaseDataSet";
            this.ahbsdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hastaAdresBilgiTableAdapter
            // 
            this.hastaAdresBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // hastaKimlikBilgiTableAdapter
            // 
            this.hastaKimlikBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1014, 579);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Yeni Muayene Girişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HastaKabulForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1563, 1033);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SilButon);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Arama);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HastaKabulForm";
            this.Text = "Hasta Kabul";
            this.Load += new System.EventHandler(this.HastaKabulForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaKimlikBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahbsdatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastaAdresBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ahbsdatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SilButon;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Arama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ahbsdatabaseDataSet ahbsdatabaseDataSet;
        private System.Windows.Forms.BindingSource hastaAdresBilgiBindingSource;
        private ahbsdatabaseDataSetTableAdapters.HastaAdresBilgiTableAdapter hastaAdresBilgiTableAdapter;
        private ahbsdatabaseDataSet1 ahbsdatabaseDataSet1;
        private System.Windows.Forms.BindingSource hastaKimlikBilgiBindingSource;
        private ahbsdatabaseDataSet1TableAdapters.HastaKimlikBilgiTableAdapter hastaKimlikBilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiSoyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anneAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uyrukDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumYeriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doğumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGüvenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sosyalGüvenlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medeniDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}