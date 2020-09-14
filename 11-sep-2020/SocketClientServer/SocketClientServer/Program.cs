using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Microsoft.SqlServer.Server;
using System.Threading;

namespace SocketServer
{
    class Program
    {
        //static byte[] Buffer { get; set; }
        static Socket ServerSocket;
        static void Main(string[] args)
        {
            ServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ServerSocket.Bind(new IPEndPoint(IPAddress.Parse("192.168.1.33"), 1111));
            ServerSocket.Listen(100);
            Console.WriteLine("server is listening");
            Socket ClientSocket = default(Socket);
            int counter = 0;
            while(true)
            {
                counter++;
                ClientSocket = ServerSocket.Accept();
                Console.WriteLine(counter + "Clients Connected ");
                Thread userthread = new Thread(new ThreadStart(() => user(ClientSocket)));
                userthread.Start();
            }
           
        }
        public static void user(Socket SocketClient)
        {
            while(true)
            {
                byte[] msgtoServer = new byte[1024];
                int size = SocketClient.Receive(msgtoServer);
                SocketClient.Send(msgtoServer, 0, size, SocketFlags.None);
            }
        }
    }
}
