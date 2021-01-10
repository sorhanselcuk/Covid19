using C19P.Is.Abstract;
using C19P.Is.Concrete;
using C19P.Is.Observer;
using C19P.Veri.Concrete;
using C19P.VeriErisim.Concrete.Excel;
using C19P.VeriErisim.Concrete.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C19P.FormUI
{
    public partial class Form1 : Form
    {
        ICovidBilgiServis _covidBilgiServis;
        ICovidVeriGirisServis _covidVeriGirisServis;
        public Form1()
        {
            InitializeComponent();
            _covidBilgiServis = new CovidBilgiYonetimi(new SQLCovidVeriDal());
            _covidVeriGirisServis = new CovidVeriGirisYonetimi(new SQLCovidVeriDal());
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            TumBilgileriYukle();
        }

        private void TumBilgileriYukle()
        {
            dgwCovidVeri.DataSource = _covidBilgiServis.HepsiniGetir();
        }

        private void btnVeriGirisi_Click(object sender, EventArgs e)
        {
            try
            {
                _covidVeriGirisServis.Ekle(new CovidVeri
                {
                    Tarih = dtpTarih.Value,
                    EntubeSayisi = Convert.ToInt32(tbxEntubeSayisi.Text),
                    IyilesenSayisi = Convert.ToInt32(tbxIyilesenSayisi.Text),
                    TestSayisi = Convert.ToInt32(tbxTestSayisi.Text),
                    VakaSayisi = Convert.ToInt32(tbxVakaSayisi.Text),
                    VefatSayisi = Convert.ToInt32(tbxVefatSayisi.Text)
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            TumBilgileriYukle();
        }

        private void dgwCovidVeri_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var tarih = Convert.ToDateTime(dgwCovidVeri.CurrentRow.Cells[1].Value.ToString());
            if (MessageBox.Show(tarih.ToString("dd MMMM yyyy") + " tarihli veriyi sileceksiniz onaylıyor musunuz ", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                _covidVeriGirisServis.Sil(Convert.ToDateTime(tarih));
            TumBilgileriYukle();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _covidVeriGirisServis.Guncelle(new CovidVeri
                {
                    Tarih = Convert.ToDateTime(tbxGuncelleTarih.Text),
                    EntubeSayisi = Convert.ToInt32(tbxGuncelleEntubeSayisi.Text),
                    IyilesenSayisi = Convert.ToInt32(tbxGuncelleIyilesenSayisi.Text),
                    TestSayisi = Convert.ToInt32(tbxGuncelleTestSayisi.Text),
                    VakaSayisi = Convert.ToInt32(tbxGuncelleVakaSayisi.Text),
                    VefatSayisi = Convert.ToInt32(tbxGuncelleVefatSayisi.Text)
                });
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            TumBilgileriYukle();
        }

        private void dgwCovidVeri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxGuncelleTarih.Text = dgwCovidVeri.CurrentRow.Cells[1].Value.ToString();
            tbxGuncelleTestSayisi.Text = dgwCovidVeri.CurrentRow.Cells[2].Value.ToString(); ;
            tbxGuncelleEntubeSayisi.Text = dgwCovidVeri.CurrentRow.Cells[3].Value.ToString();
            tbxGuncelleVakaSayisi.Text = dgwCovidVeri.CurrentRow.Cells[4].Value.ToString();
            tbxGuncelleVefatSayisi.Text = dgwCovidVeri.CurrentRow.Cells[5].Value.ToString();
            tbxGuncelleIyilesenSayisi.Text = dgwCovidVeri.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
