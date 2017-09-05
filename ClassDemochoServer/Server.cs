using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemochoServer
{
    public class Server
    {
        public Server()
        {
            
        }

        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 7);
            server.Start();

            using (TcpClient client = server.AcceptTcpClient())
            DoClient(client);
        }

        private static void DoClient(TcpClient client)
        {
            using (Stream ns = client.GetStream())
            using (StreamReader sr = new StreamReader(ns))
            using (StreamWriter sw = new StreamWriter(ns))
            {
                String inline = sr.ReadLine();
                String outLine = HandleClient(inline);

                sw.WriteLine(outLine);
                sw.Flush();
            }
        }

        public static String HandleClient(String line)
        {
            Console.WriteLine("server modtaget : " + line);
            return line;
        }
    }
}
