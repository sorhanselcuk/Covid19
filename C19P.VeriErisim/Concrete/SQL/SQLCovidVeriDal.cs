using C19P.Veri.Concrete;
using C19P.VeriErisim.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19P.VeriErisim.Concrete.SQL
{
    public class SQLCovidVeriDal : SQLBase, ICovidVeriDal
    {
        public void Ekle(CovidVeri veri)
        {
            _sqlConnection = new SqlConnection(_yol);
            BaglantiAc();
            string commandText = "exec spGunlukVeriEkle " +
                "@Tarih,@EntubeSayisi,@TestSayisi,@VakaSayisi,@VefatSayisi,@IyilesenSayisi";
            _sqlCommand = new SqlCommand(commandText, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _sqlCommand.Parameters.AddWithValue("@EntubeSayisi", veri.EntubeSayisi);
            _sqlCommand.Parameters.AddWithValue("@TestSayisi", veri.TestSayisi);
            _sqlCommand.Parameters.AddWithValue("@VakaSayisi", veri.VakaSayisi);
            _sqlCommand.Parameters.AddWithValue("@VefatSayisi", veri.VefatSayisi);
            _sqlCommand.Parameters.AddWithValue("@IyilesenSayisi", veri.IyilesenSayisi);
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public CovidVeri Getir(CovidVeri veri)
        {
            CovidVeri covidVeri = new CovidVeri();
            _sqlConnection = new SqlConnection(_yol);
            BaglantiAc();
            string commandText = "Select * from GunlukVeriler where Tarih=@Tarih";
            _sqlCommand = new SqlCommand(commandText, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                covidVeri.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                covidVeri.Tarih = Convert.ToDateTime(sqlDataReader["Tarih"].ToString());
                covidVeri.EntubeSayisi = Convert.ToInt32(sqlDataReader["EntubeSayisi"].ToString());
                covidVeri.IyilesenSayisi = Convert.ToInt32(sqlDataReader["IyilesenSayisi"].ToString());
                covidVeri.TestSayisi = Convert.ToInt32(sqlDataReader["TestSayisi"].ToString());
                covidVeri.VakaSayisi = Convert.ToInt32(sqlDataReader["VakaSayisi"].ToString());
                covidVeri.VefatSayisi = Convert.ToInt32(sqlDataReader["VefatSayisi"].ToString());

            }
            sqlDataReader.Close();
            _sqlConnection.Close();
            return covidVeri;
        }

        public void Guncelle(CovidVeri veri)
        {
            _sqlConnection = new SqlConnection(_yol);
            BaglantiAc();
            string commandText = "Update GunlukVeriler set Tarih=@Tarih,EntubeSayisi=@EntubeSayisi,TestSayisi=@TestSayisi,VakaSayisi=@VakaSayisi,VefatSayisi=@VefatSayisi,IyilesenSayisi=@IyilesenSayisi where Tarih=@Tarih";
            _sqlCommand = new SqlCommand(commandText, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _sqlCommand.Parameters.AddWithValue("@EntubeSayisi", veri.EntubeSayisi);
            _sqlCommand.Parameters.AddWithValue("@TestSayisi", veri.TestSayisi);
            _sqlCommand.Parameters.AddWithValue("@VakaSayisi", veri.VakaSayisi);
            _sqlCommand.Parameters.AddWithValue("@VefatSayisi", veri.VefatSayisi);
            _sqlCommand.Parameters.AddWithValue("@IyilesenSayisi", veri.IyilesenSayisi);
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }

        public List<CovidVeri> HepsiniGetir()
        {
            List<CovidVeri> covidVeriler = new List<CovidVeri>();
            _sqlConnection = new SqlConnection(_yol);
            BaglantiAc();
            string commandText = "Select * from GunlukVeriler";
            _sqlCommand = new SqlCommand(commandText, _sqlConnection);
            
            SqlDataReader sqlDataReader = _sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                CovidVeri covidVeri = new CovidVeri();
                covidVeri.Id = Convert.ToInt32(sqlDataReader["Id"].ToString());
                covidVeri.Tarih = Convert.ToDateTime(sqlDataReader["Tarih"].ToString());
                covidVeri.EntubeSayisi = Convert.ToInt32(sqlDataReader["EntubeSayisi"].ToString());
                covidVeri.IyilesenSayisi = Convert.ToInt32(sqlDataReader["IyilesenSayisi"].ToString());
                covidVeri.TestSayisi = Convert.ToInt32(sqlDataReader["TestSayisi"].ToString());
                covidVeri.VakaSayisi = Convert.ToInt32(sqlDataReader["VakaSayisi"].ToString());
                covidVeri.VefatSayisi = Convert.ToInt32(sqlDataReader["VefatSayisi"].ToString());
                covidVeriler.Add(covidVeri);
            }
            sqlDataReader.Close();
            _sqlConnection.Close();
            return covidVeriler;
        }

        public void Sil(CovidVeri veri)
        {
            _sqlConnection = new SqlConnection(_yol);
            BaglantiAc();
            string commandText = "delete from GunlukVeriler where Tarih=@Tarih";
            _sqlCommand = new SqlCommand(commandText, _sqlConnection);
            _sqlCommand.Parameters.AddWithValue("@Tarih", veri.Tarih);
            _sqlCommand.ExecuteNonQuery();
            _sqlConnection.Close();
        }
    }
}
