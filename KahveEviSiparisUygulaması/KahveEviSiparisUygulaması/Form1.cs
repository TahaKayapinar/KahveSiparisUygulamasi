using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveEviSiparisUygulaması
{
    using Model;
    public partial class Form1 : Form
    {
       
        List<Product> KahveListesi = new List<Product>();    //İçecek Kahve Listesi

        List<Product> SogukIcecekListesi = new List<Product>();    // Soğuk İçecekler

        List<Product> SicakIcecekListesi = new List<Product>();    //Sıcak İçecekler

        List<Order> Orders = new List<Order>();    //Siparişler

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FormFill();

        }

        private void FormFill()
        {
            FillData();

            FillForm();
        }

       
        private void FillData()
            // Burda list lerin içine data doldurma işlemi yapılacak
        {
            FillKahveListesi();

            FillSogukIcecekListesi();

            FillSicakIcecekListesi();

          
        }

        private void FillSicakIcecekListesi()
        {

            SicakIcecekListesi.Add(new Product() { Adi = "Çay", Fiyat = 3m });
            SicakIcecekListesi.Add(new Product() { Adi = "Hot Chocolate", Fiyat = 4.5m });
            SicakIcecekListesi.Add(new Product() { Adi = "Chai Tea Latte", Fiyat = 6.5m });
        }

        private void FillSogukIcecekListesi()
        {
            SogukIcecekListesi.Add(new Product() { Adi = "Su", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Soda", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Limonata", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Meyve Suyu", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Süt", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Kola", Fiyat = 5.5m });
            SogukIcecekListesi.Add(new Product() { Adi = "Sprite", Fiyat = 5.5m });
        }

        private void FillKahveListesi()
        {
            KahveListesi.Add(new Product() { Adi = "Misto", Fiyat = 4.5m });
            KahveListesi.Add(new Product() { Adi = "Americano", Fiyat = 5.75m });
            KahveListesi.Add(new Product() { Adi = "Bianco", Fiyat = 6m });
            KahveListesi.Add(new Product() { Adi = "Cappucino", Fiyat = 7.5m });
            KahveListesi.Add(new Product() { Adi = "Macchiato", Fiyat = 6.75m });
            KahveListesi.Add(new Product() { Adi = "Con Panna", Fiyat = 8m });
            KahveListesi.Add(new Product() { Adi = "Mocha", Fiyat = 7.75m });
        }


        //form üzerinde dolması gereken kontroller var ise dolduracak
        private void FillForm()
        {
            FillComboCoffeeDribk();
            FillComboColdDrink();
            FillComboHotDrink();
        }

        private void FillComboHotDrink()
        {
           
            FillComboDataSource<Product>(cmbSicakIcecekler, SicakIcecekListesi);

        }

        private void FillComboColdDrink()
        {
            
            FillComboDataSource<Product>(cmbSogukIcecekler, SogukIcecekListesi);

        }

        private void FillComboCoffeeDribk()
        {
           
            FillComboDataSource<Product> (cmbKahveler, KahveListesi);
        }

        private void FillComboDataSource<T> (ComboBox cmb, List<T> dataSource)  
        {
            cmb.Items.Clear();
            foreach (var item in dataSource)
            {
                cmb.Items.Add(item);
            }
            //cmb.SelectedIndex = 0;
        }





        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (formValid())
            {
                OrderSave();
            }
        }

        private void OrderSave()
        {
            var order = new Order();
            order.NameSurname = txtAdSoyad.Text;
            order.Phone = txtTelefon.Text;
            order.Address = txtAdres.Text;

            if (cmbKahveler.SelectedIndex > -1)
                order.Coffee = (Product)cmbKahveler.SelectedItem;

            if (cmbSogukIcecekler.SelectedIndex > -1)
                order.ColdDrink = (Product)cmbSogukIcecekler.SelectedItem;

            if (cmbSicakIcecekler.SelectedIndex > -1)
              order.HotDrink = (Product)cmbSicakIcecekler.SelectedItem;

            order.CoffeCount = Convert.ToInt32(nuCoffeeCount.Value);
            order.ColdDrinkCount = Convert.ToInt32(nuColdDrinkCount.Value);
            order.HotDrinkCount = Convert.ToInt32(nuHotDrinkCount.Value);

            if (rbShot1x.Checked)
                order.Shot = 1;
            else order.Shot = 2;

            order.Milk = rbMilkLEan.Checked ? (short)1 : (short)2;
            order.Size = rbTall.Checked ? (short)1 : rbGrande.Checked ? (short)2 : (short)3;

            // listeye ekleme işlemi yaptık
            Orders.Add(order);
            RefreshListbox();
        }


        // ekrandaki listbox yani siparişleri refresh etmek için kullanılacaktır.  Yeni sipariş eklerken aslında mantıken hepsini en baştan yazar
        private void RefreshListbox()
        {
            lsbSiparisler.Items.Clear();
            foreach (var order in Orders)
            {
                lsbSiparisler.Items.Add(order);
            }
        }

        public decimal GrandTotal()
        {
            decimal grandTotal = 0;
            
            foreach (var order in Orders)
            {
                grandTotal += order.Total;
            }
            return grandTotal;
        }

        public void LabelGrandTotal()
        {
            lblGrandTotal.Text = $"Toplam tutar => {GrandTotal().ToString("N2")}";

        }


        private void btnORderCalculate_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show($"Toplam {Orders.Count} adet ürün {GrandTotal()} tutar tutmaktadır. Onaylıyormusunuz", "Kahve Dünyası", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK)
            {
                //Bütün siparişleri temizle
                //ekranı temizle
                LabelGrandTotal();
            }

        }


        private bool formValid()
        {
            bool result = false;
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))  // boş olmasın veya space tuşuna basılmış olmasın
            {
                MessageBox.Show("İsim girilmelidir !!!", "Kahve Evi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAdSoyad.Focus();
            }
            else
                result = true;
            return result;
        }

        
    }
}
