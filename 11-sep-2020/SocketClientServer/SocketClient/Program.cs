using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
namespace SocketClient
{
    class Program
    {
        static Socket sck;
        static void Main(string[] args)
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.33"), 1111);
            try
            {
                sck.Connect(localEndPoint);
            }
            catch
            {
                Console.WriteLine("unable to remote end point");
            }
            Console.WriteLine("enter the text: ");
            String text = Console.ReadLine();
            byte[] data = Encoding.ASCII.GetBytes(text);
            sck.Send(data);
            Console.WriteLine("Data sent ");
            Console.WriteLine("Press any to continue");
            Console.Read();
            sck.Close();
        }
    }
}
