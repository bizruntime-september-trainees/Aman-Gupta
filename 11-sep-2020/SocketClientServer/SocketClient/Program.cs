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
        static Socket ClientSocket;
        static void Main(string[] args)
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.33"), 1111);
            try
            {
                ClientSocket.Connect(localEndPoint);
                Console.WriteLine("Clients is connected");
            }
            catch
            {
                Console.WriteLine("unable to remote end point");
            }
            while (true)
            {
                Console.WriteLine("enter the text: ");
                String text = Console.ReadLine();
                byte[] data = Encoding.ASCII.GetBytes(text);
                ClientSocket.Send(data);
                Console.WriteLine("Data sent ");
                byte[] msgfromserver = new byte[1024];

                int size=ClientSocket.Receive(msgfromserver);
                Console.WriteLine("server"+System.Text.Encoding.ASCII.GetString(msgfromserver,0,size));
            }
            Console.WriteLine("Press any to continue");
            Console.Read();
            ClientSocket.Close();
        }
    }
}
