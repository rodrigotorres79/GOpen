using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace EOPenServer
{
    internal class AsynchronousSocketListener
    {
        public static ManualResetEvent allDone = new ManualResetEvent(false);

        public void Start() {
            var permission = new SocketPermission(NetworkAccess.Accept,
                       TransportType.Tcp, "", SocketPermission.AllPorts);

            IPHostEntry ipHost = Dns.GetHostEntry(""); // AddressFamily.InterNetwork
            IPAddress ipAddr = null;
            for (int i = 0; i < ipHost.AddressList.LongLength; i++) {
                if (ipHost.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    ipAddr = ipHost.AddressList[i];
            }
            var ipEndPoint = new IPEndPoint(ipAddr, 4510);
            Console.WriteLine("IP Address: " + ipAddr.ToString());

            //Socket listener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp); //  ipAddr.AddressFamily

            //try {
            //    listener.Bind(ipEndPoint);
            //    listener.Listen(100);

            //    while (true) {
            //        // Set the event to nonsignaled state.  
            //        allDone.Reset();

            //        // Start an asynchronous socket to listen for connections.  
            //        Console.WriteLine("Waiting for a connection...");
            //        listener.BeginAccept(
            //            new AsyncCallback(AcceptCallback),
            //            listener);

            //        // Wait until a connection is made before continuing.  
            //        allDone.WaitOne();
            //    }

            //}
            //catch (Exception e) {
            //    Console.WriteLine(e.ToString());
            //} 
        }
    }
}
