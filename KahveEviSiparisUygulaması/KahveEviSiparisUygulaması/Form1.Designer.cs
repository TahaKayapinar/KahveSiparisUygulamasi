namespace KahveEviSiparisUygulaması
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuHotDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.nuColdDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.nuCoffeeCount = new System.Windows.Forms.NumericUpDown();
            this.cmbSicakIcecekler = new System.Windows.Forms.ComboBox();
            this.cmbSogukIcecekler = new System.Windows.Forms.ComboBox();
            this.cmbKahveler = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbShot2x = new System.Windows.Forms.RadioButton();
            this.rbShot1x = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbMilkSoy = new System.Windows.Forms.RadioButton();
            this.rbMilkLEan = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbTall = new System.Windows.Forms.RadioButton();
            this.rbGrande = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.rbVenti = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lsbSiparisler = new System.Windows.Forms.ListBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnORderCalculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHotDrinkCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuColdDrinkCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCoffeeCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::KahveEviSiparisUygulaması.Properties.Resources.Kahve;
            this.pictureBox4.Location = new System.Drawing.Point(170, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(81, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(257, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asya Kahve Evi Sipariş Ekranı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(103, 84);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(328, 94);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(103, 53);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(328, 25);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(103, 22);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(328, 25);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Adres : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefon : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuHotDrinkCount);
            this.groupBox2.Controls.Add(this.nuColdDrinkCount);
            this.groupBox2.Controls.Add(this.nuCoffeeCount);
            this.groupBox2.Controls.Add(this.cmbSicakIcecekler);
            this.groupBox2.Controls.Add(this.cmbSogukIcecekler);
            this.groupBox2.Controls.Add(this.cmbKahveler);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 296);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 175);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // nuHotDrinkCount
            // 
            this.nuHotDrinkCount.Location = new System.Drawing.Point(385, 130);
            this.nuHotDrinkCount.Name = "nuHotDrinkCount";
            this.nuHotDrinkCount.Size = new System.Drawing.Size(46, 25);
            this.nuHotDrinkCount.TabIndex = 11;
            // 
            // nuColdDrinkCount
            // 
            this.nuColdDrinkCount.Location = new System.Drawing.Point(385, 80);
            this.nuColdDrinkCount.Name = "nuColdDrinkCount";
            this.nuColdDrinkCount.Size = new System.Drawing.Size(46, 25);
            this.nuColdDrinkCount.TabIndex = 10;
            // 
            // nuCoffeeCount
            // 
            this.nuCoffeeCount.Location = new System.Drawing.Point(385, 32);
            this.nuCoffeeCount.Name = "nuCoffeeCount";
            this.nuCoffeeCount.Size = new System.Drawing.Size(46, 25);
            this.nuCoffeeCount.TabIndex = 9;
            // 
            // cmbSicakIcecekler
            // 
            this.cmbSicakIcecekler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSicakIcecekler.FormattingEnabled = true;
            this.cmbSicakIcecekler.Location = new System.Drawing.Point(186, 129);
            this.cmbSicakIcecekler.Name = "cmbSicakIcecekler";
            this.cmbSicakIcecekler.Size = new System.Drawing.Size(183, 25);
            this.cmbSicakIcecekler.TabIndex = 8;
            // 
            // cmbSogukIcecekler
            // 
            this.cmbSogukIcecekler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSogukIcecekler.FormattingEnabled = true;
            this.cmbSogukIcecekler.Location = new System.Drawing.Point(186, 80);
            this.cmbSogukIcecekler.Name = "cmbSogukIcecekler";
            this.cmbSogukIcecekler.Size = new System.Drawing.Size(183, 25);
            this.cmbSogukIcecekler.TabIndex = 7;
            // 
            // cmbKahveler
            // 
            this.cmbKahveler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKahveler.FormattingEnabled = true;
            this.cmbKahveler.Location = new System.Drawing.Point(186, 32);
            this.cmbKahveler.Name = "cmbKahveler";
            this.cmbKahveler.Size = new System.Drawing.Size(183, 25);
            this.cmbKahveler.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Sıcak İçecekler :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Soğuk İçecekler :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::KahveEviSiparisUygulaması.Properties.Resources.Sıcak_İçecekler;
            this.pictureBox3.Location = new System.Drawing.Point(8, 124);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(53, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::KahveEviSiparisUygulaması.Properties.Resources.Soğuk_İçecekler;
            this.pictureBox2.Location = new System.Drawing.Point(10, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KahveEviSiparisUygulaması.Properties.Resources.Kahve;
            this.pictureBox1.Location = new System.Drawing.Point(10, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kahveler :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbShot2x);
            this.groupBox3.Controls.Add(this.rbShot1x);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(21, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 41);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ekstralar";
            // 
            // rbShot2x
            // 
            this.rbShot2x.AutoSize = true;
            this.rbShot2x.Location = new System.Drawing.Point(233, 15);
            this.rbShot2x.Name = "rbShot2x";
            this.rbShot2x.Size = new System.Drawing.Size(40, 21);
            this.rbShot2x.TabIndex = 2;
            this.rbShot2x.Text = "2x";
            this.rbShot2x.UseVisualStyleBackColor = true;
            // 
            // rbShot1x
            // 
            this.rbShot1x.AutoSize = true;
            this.rbShot1x.Checked = true;
            this.rbShot1x.Location = new System.Drawing.Point(178, 15);
            this.rbShot1x.Name = "rbShot1x";
            this.rbShot1x.Size = new System.Drawing.Size(38, 21);
            this.rbShot1x.TabIndex = 1;
            this.rbShot1x.TabStop = true;
            this.rbShot1x.Text = "1x";
            this.rbShot1x.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Shot";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbMilkSoy);
            this.panel2.Controls.Add(this.rbMilkLEan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(23, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 35);
            this.panel2.TabIndex = 5;
            // 
            // rbMilkSoy
            // 
            this.rbMilkSoy.AutoSize = true;
            this.rbMilkSoy.Location = new System.Drawing.Point(245, 7);
            this.rbMilkSoy.Name = "rbMilkSoy";
            this.rbMilkSoy.Size = new System.Drawing.Size(55, 21);
            this.rbMilkSoy.TabIndex = 4;
            this.rbMilkSoy.Text = "Soya";
            this.rbMilkSoy.UseVisualStyleBackColor = true;
            // 
            // rbMilkLEan
            // 
            this.rbMilkLEan.AutoSize = true;
            this.rbMilkLEan.Checked = true;
            this.rbMilkLEan.Location = new System.Drawing.Point(176, 7);
            this.rbMilkLEan.Name = "rbMilkLEan";
            this.rbMilkLEan.Size = new System.Drawing.Size(63, 21);
            this.rbMilkLEan.TabIndex = 3;
            this.rbMilkLEan.TabStop = true;
            this.rbMilkLEan.Text = "Yağsız";
            this.rbMilkLEan.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(58, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Süt :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbTall);
            this.panel3.Controls.Add(this.rbGrande);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.rbVenti);
            this.panel3.Location = new System.Drawing.Point(23, 565);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(426, 37);
            this.panel3.TabIndex = 6;
            // 
            // rbTall
            // 
            this.rbTall.AutoSize = true;
            this.rbTall.Checked = true;
            this.rbTall.Location = new System.Drawing.Point(330, 7);
            this.rbTall.Name = "rbTall";
            this.rbTall.Size = new System.Drawing.Size(45, 21);
            this.rbTall.TabIndex = 8;
            this.rbTall.TabStop = true;
            this.rbTall.Text = "Tall";
            this.rbTall.UseVisualStyleBackColor = true;
            // 
            // rbGrande
            // 
            this.rbGrande.AutoSize = true;
            this.rbGrande.Location = new System.Drawing.Point(245, 7);
            this.rbGrande.Name = "rbGrande";
            this.rbGrande.Size = new System.Drawing.Size(70, 21);
            this.rbGrande.TabIndex = 7;
            this.rbGrande.Text = "Grande";
            this.rbGrande.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "İçecek Boyutu :";
            // 
            // rbVenti
            // 
            this.rbVenti.AutoSize = true;
            this.rbVenti.Location = new System.Drawing.Point(176, 7);
            this.rbVenti.Name = "rbVenti";
            this.rbVenti.Size = new System.Drawing.Size(56, 21);
            this.rbVenti.TabIndex = 6;
            this.rbVenti.Text = "Venti";
            this.rbVenti.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHesapla.Location = new System.Drawing.Point(23, 624);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(426, 41);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lsbSiparisler);
            this.groupBox4.Location = new System.Drawing.Point(466, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 419);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Siparişler";
            // 
            // lsbSiparisler
            // 
            this.lsbSiparisler.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsbSiparisler.FormattingEnabled = true;
            this.lsbSiparisler.ItemHeight = 17;
            this.lsbSiparisler.Location = new System.Drawing.Point(6, 24);
            this.lsbSiparisler.Name = "lsbSiparisler";
            this.lsbSiparisler.Size = new System.Drawing.Size(404, 378);
            this.lsbSiparisler.TabIndex = 0;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGrandTotal.Location = new System.Drawing.Point(572, 561);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(304, 30);
            this.lblGrandTotal.TabIndex = 9;
            this.lblGrandTotal.Text = "Toplam Sipariş Tutarı :  0.00 TL";
            // 
            // btnORderCalculate
            // 
            this.btnORderCalculate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnORderCalculate.Location = new System.Drawing.Point(472, 624);
            this.btnORderCalculate.Name = "btnORderCalculate";
            this.btnORderCalculate.Size = new System.Drawing.Size(410, 41);
            this.btnORderCalculate.TabIndex = 12;
            this.btnORderCalculate.Text = "Sipariş Ver";
            this.btnORderCalculate.UseVisualStyleBackColor = false;
            this.btnORderCalculate.Click += new System.EventHandler(this.btnORderCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 677);
            this.Controls.Add(this.btnORderCalculate);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asya Kahve Evi ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuHotDrinkCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuColdDrinkCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCoffeeCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.NumericUpDown nuHotDrinkCount;
        private System.Windows.Forms.NumericUpDown nuColdDrinkCount;
        private System.Windows.Forms.NumericUpDown nuCoffeeCount;
        private System.Windows.Forms.ComboBox cmbSicakIcecekler;
        private System.Windows.Forms.ComboBox cmbSogukIcecekler;
        private System.Windows.Forms.ComboBox cmbKahveler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbShot2x;
        private System.Windows.Forms.RadioButton rbShot1x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbMilkSoy;
        private System.Windows.Forms.RadioButton rbMilkLEan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rbTall;
        private System.Windows.Forms.RadioButton rbGrande;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbVenti;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lsbSiparisler;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Button btnORderCalculate;
    }
}

