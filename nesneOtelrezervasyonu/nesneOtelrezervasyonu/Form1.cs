using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nesneOtelrezervasyonu
{
    public partial class Form1 : Form
    {
        List<Müsteribilgileri> müsteriler = new List<Müsteribilgileri>();
        List<rezervasyonbilgisi> rezervasyon = new List<rezervasyonbilgisi>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            müsteridoldur();
            rezervasyondoldur();
            ödemedoldur();
            odasec.Items.Add("denize bakan");
            odasec.Items.Add("ormana bakan");
            ödeme.Items.Add("kredi kartı");
            ödeme.Items.Add("nakit");
           

        }
        public void müsteridoldur()
        {
            Müsteribilgileri y = new Müsteribilgileri();
            y.Ad = "";
            y.Soyad = "";
            y.TCKN = "";
            y.mail = "";
            y.iletisimno = "";
            
            
            MessageBox.Show(y.Ad + " " + y.Soyad + " adlı müsteri eklendi ");
            
            y.müsteri = new List<Müsteribilgileri>();

        }
        public void rezervasyondoldur()
        {


            rezervasyonbilgisi k = new rezervasyonbilgisi();
            k.kisisayisi = "";
            k.odasec = "";
           
            DateTime timebaslangic = DateTime.Now;
            DateTime timebitis = DateTime.Now;
            
            odasec.Items.Add("denize bakan");
            odasec.Items.Add("ormana bakan");

            MessageBox.Show(k.kisisayisi + ""+odasec+""+timebaslangic+""+timebitis+ " adlı rezerve eklendi ");
            k.rezervasyon = new List<rezervasyonbilgisi>();

      


        }
        public void ödemedoldur()
        {


            ödemeislemi c = new ödemeislemi();
            c.odemeturu = "";
            ödeme.Items.Add("kredi kartı");
            ödeme.Items.Add("nakit");
            MessageBox.Show(c.odemeturu + "" + ödeme + " ödenecektir");

        
        
        
        
        
        }

        public enum gunler
        {
            pazartesi,
            sali,
            carsamba,
            persembe,
            cuma,
            cumartesi,
            pazar





        }
        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Müsteribilgileri y = new Müsteribilgileri();
            y.Ad = txtad.Text;
            y.Soyad = txtsoyad.Text;
            y.TCKN = txtkimlik.Text;
            y.adres = txtadres.Text;
            y.mail = txtmail.Text;
            
            y.iletisimno = txtno.Text;
            müsteriler.Add(y);
            
            txtad.Text = "";
            txtsoyad.Text = "";
            txtkimlik.Text = "";
            txtadres.Text = "";
            txtmail.Text = "";
            MessageBox.Show(y.Ad + " " + y.Soyad + " "+y.TCKN+" "+"  adlı müsteri eklendi ");
            byte i = Convert.ToByte(txtgunsayi.Text);
            gunler GunAdi;
            GunAdi = (gunler)i;  
            MessageBox.Show(GunAdi.ToString()+" "+"günü");
            rezervasyonbilgisi k = new rezervasyonbilgisi();
            k.odasec = "";
            MessageBox.Show(k.kisisayisi + "" + odasec + "" + timebaslangic + "" + timebitis + " adlı rezerve eklendi ");
            k.rezervasyon = new List<rezervasyonbilgisi>();
            lstMüsteriler.Items.Add(y.Ad + " " + y.Soyad + " - " + y.TCKN+  " " +y.mail+ "" +y.iletisimno+""+y.adres+""+k.timebaslangic+""+k.timebitis+""+k.odasec);
            int kisisayisi = Convert.ToInt32(numericUpDown1.Value);
            odasec.Items.Add("denize bakan");
            odasec.Items.Add("ormana bakan");
            ödeme.Items.Add("kredi kartı");
            ödeme.Items.Add("nakit");
            ödemeislemi c = new ödemeislemi();
            c.odemeturu = "";
             
        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
            e.Handled = Char.IsPunctuation(e.KeyChar);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }

    


}

