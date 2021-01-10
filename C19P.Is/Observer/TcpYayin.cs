using C19P.Is.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace C19P.Is.Observer
{
    public class TcpYayin : IObserver
    {
        private TcpListener _tcpListener;
        private TcpClient _tcpClient;
        private NetworkStream _networkStream;
        private Byte[] _bytes;
        public TcpYayin(Server server)
        {

            _tcpListener = new TcpListener(server.IPAddress, server.Port);
            _bytes = new Byte[16384];
            _tcpListener.Start();



        }
        public void Update(string json)
        {
            try
            {

                _tcpClient = _tcpListener.AcceptTcpClient();

                _networkStream = _tcpClient.GetStream();

                byte[] veri = System.Text.Encoding.ASCII.GetBytes(json);
                _networkStream.Write(veri, 0, veri.Length);


                _tcpClient.Close();
            }
            catch (Exception exception)
            {
                throw new Exception("Server oluşturulurken bir hata meydana geldi !");
            }
        }
    }
}
