using C19P.Is.Abstract;
using C19P.Is.Concrete;
using C19P.Is.Observer;
using C19P.VeriErisim.Concrete.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Yayin
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("Yayın başladı !");
            ITcpYayinServis tcpYayinServis = new TcpYayinYonetimi(new TcpPortSubject(new CovidBilgiYonetimi(new SQLCovidVeriDal())));
            tcpYayinServis.DinleyiciEkle(new TcpYayin(new Server
            {
                IPAddress = IPAddress.Parse("127.0.0.1"),
                Port = 13004
            }));
            while (true)
            {
                tcpYayinServis.YayinBaslat();
            }
            }catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
