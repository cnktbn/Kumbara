using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CenkBahçelilerKumbara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kumbara.KumbaraHacim = 10000;
            btnKumbaraYapistir.Enabled = false;
        }
        Kumbara kumbara = new Kumbara();
        double Bakiye = 0;
        private void btnOnKurus_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                BozukPara onKurus = new BozukPara();
                onKurus.Deger = BozukPara.Onkurus;
                onKurus.Cap = 18.5;
                onKurus.hYukseklik = 1;
                kumbara.KumbaraHacim -= onKurus.HacimHesapla();
                kumbara.BozukParaKumbaraListesi.Add(onKurus);
                listBox1.Items.Add(onKurus.Deger + " Lira ");
                Bakiye += onKurus.Deger;
                txtBakiye.Text = Bakiye.ToString() + " Lira";
                txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                kumbara.Paralarinhacmi += onKurus.HacimHesapla();
                txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnYirmibesKurus_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                BozukPara yirmibeskurus = new BozukPara();
                yirmibeskurus.Deger = BozukPara.YirmibesKurus;
                yirmibeskurus.Cap = 20.5;
                yirmibeskurus.hYukseklik = 1;
                kumbara.KumbaraHacim -= yirmibeskurus.HacimHesapla();

                kumbara.BozukParaKumbaraListesi.Add(yirmibeskurus);
                listBox1.Items.Add(yirmibeskurus.Deger + " Lira ");
                Bakiye += yirmibeskurus.Deger;
                txtBakiye.Text = Bakiye.ToString() + " Lira";
                txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                kumbara.Paralarinhacmi += yirmibeskurus.HacimHesapla();
                txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnElliKurus_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                BozukPara ellikurus = new BozukPara();
                ellikurus.Deger = BozukPara.ElliKurus;
                ellikurus.Cap = 23.85;
                ellikurus.hYukseklik = 1;
                kumbara.KumbaraHacim -= ellikurus.HacimHesapla();
                kumbara.BozukParaKumbaraListesi.Add(ellikurus);
                listBox1.Items.Add(ellikurus.Deger + " Lira ");
                Bakiye += ellikurus.Deger;
                txtBakiye.Text = Bakiye.ToString() + " Lira";
                txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                kumbara.Paralarinhacmi += ellikurus.HacimHesapla();
                txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnBirLiraBozuk_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                BozukPara birlira = new BozukPara();
                birlira.Deger = BozukPara.BirLira;
                birlira.Cap = 26.15;
                birlira.hYukseklik = 1;
                kumbara.KumbaraHacim -= birlira.HacimHesapla();
                kumbara.BozukParaKumbaraListesi.Add(birlira);
                listBox1.Items.Add(birlira.Deger + " Lira ");
                Bakiye += birlira.Deger;
                txtBakiye.Text = Bakiye.ToString() + " Lira";
                txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                kumbara.Paralarinhacmi += birlira.HacimHesapla();
                txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnBeslira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara beslira = new KagitPara();
                    beslira.Deger = KagitPara.BesLira;
                    beslira.hYukseklik = 0.25;
                    beslira.Boy = 13;
                    beslira.En = 6.4;
                    kumbara.KumbaraHacim -= beslira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(beslira);
                    listBox1.Items.Add(beslira.Deger + " Lira");
                    Bakiye += beslira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += beslira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnOnlira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara onLira = new KagitPara();
                    onLira.Deger = KagitPara.OnLira;
                    onLira.hYukseklik = 0.25;
                    onLira.Boy = 13.6;
                    onLira.En = 6.4;
                    kumbara.KumbaraHacim -= onLira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(onLira);
                    listBox1.Items.Add(onLira.Deger + " Lira");
                    Bakiye += onLira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += onLira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnYirmiLira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara yirmiLira = new KagitPara();
                    yirmiLira.Deger = KagitPara.YirmiLira;
                    yirmiLira.hYukseklik = 0.25;
                    yirmiLira.Boy = 14.2;
                    yirmiLira.En = 6.8;
                    kumbara.KumbaraHacim -= yirmiLira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(yirmiLira);
                    listBox1.Items.Add(yirmiLira.Deger + " Lira");
                    Bakiye += yirmiLira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += yirmiLira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnElliLira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {

                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara elliLira = new KagitPara();
                    elliLira.Deger = KagitPara.ElliLira;
                    elliLira.hYukseklik = 0.25;
                    elliLira.Boy = 14.8;
                    elliLira.En = 6.8;
                    kumbara.KumbaraHacim -= elliLira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(elliLira);
                    listBox1.Items.Add(elliLira.Deger + " Lira");
                    Bakiye += elliLira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += elliLira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnYüzLira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {

                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara yuzLira = new KagitPara();
                    yuzLira.Deger = KagitPara.YuzLira;
                    yuzLira.hYukseklik = 0.25;
                    yuzLira.Boy = 15.4;
                    yuzLira.En = 7.2;
                    kumbara.KumbaraHacim -= yuzLira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(yuzLira);
                    listBox1.Items.Add(yuzLira.Deger + " Lira");
                    Bakiye += yuzLira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += yuzLira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }

        }

        private void btnIkiyüzLira_Click(object sender, EventArgs e)
        {
            DolulukKontrolEt();
            if (kumbara.KirildiMi == false)
            {
                if (chkbxKatla.Checked)
                {
                    chkbxKatla.Checked = false;
                    KagitPara ikiyuzLira = new KagitPara();
                    ikiyuzLira.Deger = KagitPara.ikiyuzLira;
                    ikiyuzLira.hYukseklik = 0.25;
                    ikiyuzLira.Boy = 16;
                    ikiyuzLira.En = 7.2;
                    kumbara.KumbaraHacim -= ikiyuzLira.HacimHesapla();
                    kumbara.KumbaraListesi.Add(ikiyuzLira);
                    listBox1.Items.Add(ikiyuzLira.Deger + " Lira");
                    Bakiye += ikiyuzLira.Deger;
                    txtBakiye.Text = Bakiye.ToString() + " Lira";
                    txtHacimDoluluk.Text = kumbara.KumbaraHacim.ToString() + " Gram";
                    kumbara.Paralarinhacmi += ikiyuzLira.HacimHesapla();
                    txtParalarinHacmi.Text = kumbara.Paralarinhacmi.ToString();
                }
                else
                {
                    MessageBox.Show("Parayı Kumbaraya atmadan önce katlayınız.");
                }
            }
            else
            {
                MessageBox.Show("Kumbara kırık olduğu için para ekleyemeyiz.");
            }
        }

        private void btnKumbaraKir_Click(object sender, EventArgs e)
        {
            if (kumbara.KirildiMi == false)
            {
                btnKumbaraYapistir.Enabled = true;
                btnKumbaraKir.Enabled = false;
                kumbara.KirildiMi = true;

                MessageBox.Show("Kumbarayı kırdın.");
            }
            else
            {
                MessageBox.Show("Kumbara zaten kırık");
            }
        }

        private void btnKumbaraYapistir_Click(object sender, EventArgs e)
        {
            if (kumbara.KirildiMi == true)
            {
                if (kumbara.YapistiMi == false)
                {
                    MessageBox.Show("Yapistirdik");
                    kumbara.YapistiMi = true;
                    kumbara.KirildiMi = false;
                    btnKumbaraKir.Enabled = true;
                    btnKumbaraYapistir.Enabled = false;
                }
            }
        }

        private void btnKumbarayiSalla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kumbarayı Salladın!");
            txtParalarinHacmi.Text = kumbara.Salla(kumbara.Paralarinhacmi).ToString();
        }
        void DolulukKontrolEt()
        {
            if (kumbara.KumbaraHacim <= 50)
            {
                MessageBox.Show("Kumbara hacmi doldu!");
                btnOnKurus.Enabled = false;
                btnYirmibesKurus.Enabled = false;
                btnElliKurus.Enabled = false;
                btnBirLiraBozuk.Enabled = false;
                btnBeslira.Enabled = false;
                btnOnlira.Enabled = false;
                btnYirmiLira.Enabled = false;
                btnElliLira.Enabled = false;
                btnYüzLira.Enabled = false;
                btnIkiyüzLira.Enabled = false;
            }
        }
    }
}
