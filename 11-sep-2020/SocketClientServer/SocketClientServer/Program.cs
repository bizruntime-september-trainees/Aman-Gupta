using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Microsoft.SqlServer.Server;

namespace SocketServer
{
    class Program
    {
        static byte[] Buffer { get; set; }
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sck.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.33"), 1111));
            sck.Listen(2);
            Socket Acceptedd = sck.Accept();
            Buffer = new byte[Acceptedd.SendBufferSize];
            int byteRead = Acceptedd.Receive(Buffer);
            byte[] formatted = new byte[byteRead];
            int i;
            for ( i = 0; i < byteRead;i++)
            {
                formatted[i] = Buffer[i];
            }
            string strdata = Encoding.ASCII.GetString(formatted);
            Console.WriteLine(strdata);
            Console.Read();
            sck.Close();
            Acceptedd.Close();
        }
    }
}
