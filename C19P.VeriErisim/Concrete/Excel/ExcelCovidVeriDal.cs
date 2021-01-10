using C19P.Veri.Concrete;
using C19P.VeriErisim.Abstract;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.VeriErisim.Concrete.Excel
{
    public class ExcelCovidVeriDal : ExcelBase, ICovidVeriDal
    {

        public void Ekle(CovidVeri veri)
        {
            if(Getir(new CovidVeri { Tarih = veri.Tarih }) == null) { 
            _oleDbConnection = new OleDbConnection(_yol);
            BaglantiAc();
            string commandText = "insert into [Safya1$] (Tarih,EntubeSayisi,TestSayisi,VakaSayisi,VefatSayisi,IyilesenSayisi)" +
                " values (@Tarih,@EntubeSayisi,@TestSayisi,@VakaSayisi,@VefatSayisi,@IyilesenSayisi)";
            _oleDbCommand = new OleDbCommand(commandText, _oleDbConnection);
            _oleDbCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _oleDbCommand.Parameters.AddWithValue("@EntubeSayisi", veri.EntubeSayisi);
            _oleDbCommand.Parameters.AddWithValue("@TestSayisi", veri.TestSayisi);
            _oleDbCommand.Parameters.AddWithValue("@VakaSayisi", veri.VakaSayisi);
            _oleDbCommand.Parameters.AddWithValue("@VefatSayisi", veri.VefatSayisi);
            _oleDbCommand.Parameters.AddWithValue("@IyilesenSayisi", veri.IyilesenSayisi);
            _oleDbCommand.ExecuteNonQuery();
            _oleDbConnection.Close();
            }
            else
            {
                UstuneEkleyerekGuncelle(veri);
            }
        }

        private void UstuneEkleyerekGuncelle(CovidVeri veri)
        {
            var gelenVeri = Getir(new CovidVeri { 
            Tarih=veri.Tarih
            });
            veri.EntubeSayisi += gelenVeri.EntubeSayisi;
            veri.IyilesenSayisi += gelenVeri.IyilesenSayisi;
            veri.TestSayisi += gelenVeri.TestSayisi;
            veri.VakaSayisi += gelenVeri.VakaSayisi;
            veri.VefatSayisi += gelenVeri.VefatSayisi;
            Guncelle(veri);
        }

        public CovidVeri Getir(CovidVeri veri)
        {
            CovidVeri covidVeri = new CovidVeri();
            _oleDbConnection = new OleDbConnection(_yol);
            BaglantiAc();
            string commandText = "Select * from [Sayfa1$] where Tarih=@Tarih";
            _oleDbCommand = new OleDbCommand(commandText, _oleDbConnection);
            _oleDbCommand.Parameters.AddWithValue("@Tarih",veri.Tarih);
            OleDbDataReader oleDbDataReader = _oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {

                covidVeri.Tarih = Convert.ToDateTime(oleDbDataReader["Tarih"].ToString());
                covidVeri.EntubeSayisi = Convert.ToInt32(oleDbDataReader["EntubeSayisi"].ToString());
                covidVeri.IyilesenSayisi = Convert.ToInt32(oleDbDataReader["IyilesenSayisi"].ToString());
                covidVeri.TestSayisi = Convert.ToInt32(oleDbDataReader["TestSayisi"].ToString());
                covidVeri.VakaSayisi = Convert.ToInt32(oleDbDataReader["VakaSayisi"].ToString());
                covidVeri.VefatSayisi = Convert.ToInt32(oleDbDataReader["VefatSayisi"].ToString());

            }
            oleDbDataReader.Close();
            _oleDbConnection.Close();
            return covidVeri;
        }

        public void Guncelle(CovidVeri veri)
        {
            _oleDbConnection = new OleDbConnection(_yol);
            BaglantiAc();
            string commandText = "update [Sayfa1$] set EntubeSayisi=@EntubeSayisi,TestSayisi=@TestSayisi,VakaSayisi=@VakaSayisi," +
                "VefatSayisi=@VefatSayisi,IyilesenSayisi=@IyilesenSayisi where Tarih=@Tarih";
            _oleDbCommand = new OleDbCommand(commandText, _oleDbConnection);
            _oleDbCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _oleDbCommand.Parameters.AddWithValue("@EntubeSayisi", veri.EntubeSayisi);
            _oleDbCommand.Parameters.AddWithValue("@TestSayisi", veri.TestSayisi);
            _oleDbCommand.Parameters.AddWithValue("@VakaSayisi", veri.VakaSayisi);
            _oleDbCommand.Parameters.AddWithValue("@VefatSayisi", veri.VefatSayisi);
            _oleDbCommand.Parameters.AddWithValue("@IyilesenSayisi", veri.IyilesenSayisi);
            _oleDbCommand.ExecuteNonQuery();
            _oleDbConnection.Close();
        }

        public List<CovidVeri> HepsiniGetir()
        {
            List<CovidVeri> covidVeriler = new List<CovidVeri>();
            _oleDbConnection = new OleDbConnection(_yol);
            BaglantiAc();
            string commandText = "Select * from [Sayfa1$]";
            _oleDbCommand = new OleDbCommand(commandText, _oleDbConnection);
            OleDbDataReader oleDbDataReader = _oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                covidVeriler.Add(new CovidVeri
                {
                    Tarih = Convert.ToDateTime(oleDbDataReader["Tarih"].ToString()),
                    EntubeSayisi = Convert.ToInt32(oleDbDataReader["EntubeSayisi"].ToString()),
                    IyilesenSayisi = Convert.ToInt32(oleDbDataReader["IyilesenSayisi"].ToString()),
                    TestSayisi = Convert.ToInt32(oleDbDataReader["TestSayisi"].ToString()),
                    VakaSayisi = Convert.ToInt32(oleDbDataReader["VakaSayisi"].ToString()),
                    VefatSayisi = Convert.ToInt32(oleDbDataReader["VefatSayisi"].ToString())
                });
            }
            oleDbDataReader.Close();
            _oleDbConnection.Close();
            return covidVeriler;
        }

        public void Sil(CovidVeri veri)
        {
            _oleDbConnection = new OleDbConnection(_yol);
            BaglantiAc();
            string commandText = "delete from [Sayfa1$] where Tarih=@Tarih";
            _oleDbCommand = new OleDbCommand(commandText, _oleDbConnection);
            _oleDbCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _oleDbCommand.ExecuteNonQuery();
            _oleDbConnection.Close();
        }
    }
}
