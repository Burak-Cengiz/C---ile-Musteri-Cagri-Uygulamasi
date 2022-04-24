using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriCagriUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Ikuyruk Aramalar = new Ikuyruk(50);
        int BireyselKontrol = 2, TicariKontrol = 2;
        

        CagriOzellikleri Cagri1 = new CagriOzellikleri()
        {
            MusteriID = 4,
            MusteriTipi = "Bireysel",
            CagriID = 1,
            CagriZaman = DateTime.Now.ToLocalTime(),
        };

        CagriOzellikleri Cagri2 = new CagriOzellikleri()
        {
            MusteriID = 6,
            MusteriTipi = "Ticari",
            CagriID = 2,
            CagriZaman = DateTime.Now.ToLocalTime(),
        };

        private void timer1_Tick(object sender, EventArgs e)
        {           
            lblZaman.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Aramalar.push(Cagri1);
            Aramalar.push(Cagri2);
            Yazdir();
        }
        
        public void Yazdir()
        {
            lstBxCagrilar.Items.Clear();
            lstBxCagrilar.Items.Add("Çağrı ID" + "\tMüşteri ID" + "\tMüşteri Tipi" + "\t\tÇağrı Gönderim Zamanı");
            lstBxCagrilar.Items.Add("");

            for (int i = Aramalar.front; i <= Aramalar.rear; i++)
            {
                lstBxCagrilar.Items.Add(Aramalar.kuyruk[i].CagriID + "\t " + Aramalar.kuyruk[i].MusteriID + "\t\t" + Aramalar.kuyruk[i].MusteriTipi + "\t\t\t" + Aramalar.kuyruk[i].CagriZaman);
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {

            try
            {
                CagriOzellikleri Cagri = new CagriOzellikleri();
                Cagri.MusteriTipi = cmBxMsteriTip.Text.ToString();
                Cagri.MusteriID = Convert.ToInt32(txtBxMusteriID.Text);
                Cagri.CagriID = (Aramalar.ToplamCagri + 1);
                Cagri.CagriZaman = Convert.ToDateTime(lblZaman.Text);

                if (Cagri.MusteriTipi == "Bireysel" || Cagri.MusteriTipi == "Ticari" && Cagri.MusteriID != 0)
                {
                    Aramalar.push(Cagri);
                    MessageBox.Show("Çağrı Yapılmıştır.");
                }
                else
                    MessageBox.Show("Lütfen doğru tuşlama ve seçim yapınız!!");

                Yazdir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen doğru tuşlama yapınız", ex.Message);
            }                      

        }

        private void btnBryselCgriBtir_Click(object sender, EventArgs e)
        {
            if (BireyselKontrol == 0)
                BireyselKontrol = 1;
            else
                BireyselKontrol = 2;

            
            MessageBox.Show("Çağrı sona ermiştir. Şu an boş olan bireysel müşteri temsilci sayımız: " + BireyselKontrol);
            
        }

        private void btnTicriCagrBtr_Click(object sender, EventArgs e)
        {
            if (TicariKontrol == 0)
                TicariKontrol = 1;
            else
                TicariKontrol = 2;

            
            MessageBox.Show("Çağrı sona ermiştir. Şu an boş olan ticari müşteri temsilci sayımız: " + TicariKontrol);
           
             
        }

        private void btnCagrilar_Click(object sender, EventArgs e)
        {
            try
            {
                lstBxBtnCagrilar.Items.Clear();
                lstBxBtnCagrilar.Items.Add("Çağrı ID" + "\tMüşteri ID" + "\tMüşteri Tipi");
                lstBxBtnCagrilar.Items.Add("");

                for (int i = 0; i < Aramalar.BitenCagrilar; i++)
                {
                    lstBxBtnCagrilar.Items.Add(Aramalar.TamamlananCagrilar[i].CagriID + "\t " + Aramalar.TamamlananCagrilar[i].MusteriID + "\t\t" + Aramalar.TamamlananCagrilar[i].MusteriTipi);
                }
            }
            catch (Exception)
            {

                throw new Exception("Atanmış Çağrı yok");
            }
            
        }

        private void btnCgrID_Click(object sender, EventArgs e)
        {

            Aramalar.ChangeFront(Convert.ToInt32(txtBxOnclkID.Text));

            Yazdir();

            try
            {
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen doğru tuşlama yapınız", ex.Message);
            }
           
        }

        private void btnCagriAta_Click(object sender, EventArgs e)
        {
            CagriOzellikleri Front = (CagriOzellikleri)Aramalar.peek();
            if(Front.MusteriTipi == "Bireysel")
            {
                if (BireyselKontrol != 0)
                {
                    CagriOzellikleri temp = (CagriOzellikleri)Aramalar.pop();
                    MessageBox.Show("Sıradaki Atanan Çağrı ID :" + temp.CagriID + "  Müşteri ID :" + temp.MusteriID + "  Müşteri Tipi :" + temp.MusteriTipi);
                    BireyselKontrol--;
                    
                    MessageBox.Show("Uygun olan ticari müşteri temsilci sayımız: " + TicariKontrol + "   Uygun olan bireysel müşteri temsilci sayımız: " + BireyselKontrol);
                }
                else
                    MessageBox.Show("Bireysel Müşteri Temsilcilerimiz şu an uygun değiller! Lütfen bekleyiniz!");
            }
            else
            {
                if(TicariKontrol != 0)
                {
                    CagriOzellikleri temp = (CagriOzellikleri)Aramalar.pop();
                    MessageBox.Show("Sıradaki Atanan Çağrı ID :" + temp.CagriID + "  Müşteri ID :" + temp.MusteriID + "  Müşteri Tipi :" + temp.MusteriTipi);                   
                    TicariKontrol--;
                    
                    MessageBox.Show("Uygun olan ticari müşteri temsilci sayımız: " + TicariKontrol + "   Uygun olan bireysel müşteri temsilci sayımız: " + BireyselKontrol);
                }
                else
                    MessageBox.Show("Ticari Müşteri Temsilcilerimiz şu an uygun değiller! Lütfen bekleyiniz!");
            }

            Yazdir();

        }
    }
}
