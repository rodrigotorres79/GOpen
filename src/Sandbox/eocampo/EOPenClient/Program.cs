using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace EOPenClient
{
    class Program
    {
        static void Main(string[] args) {
            SynchronousSocketClient.StartClient();
            Console.WriteLine("Press enter");
            Console.ReadLine();
        }
    }
}
