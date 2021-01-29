using System;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace Test2A
{
    public class TcpServer
    {
        private TcpListener tcpListener;
        private Thread listenThread;

        public TcpServer()
        {
            this.tcpListener = new TcpListener(IPAddress.Any, 6888);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
            Console.WriteLine("Server started at {0} :{1} @ {2}", IPAddress.Any, 1031, DateTime.Now.ToString());
        }

        public TcpServer(IPAddress addr, int port)
        {
            this.tcpListener = new TcpListener(addr, port);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
            Console.WriteLine("Server started at {0} :{1} @ {2}", addr, port, DateTime.Now.ToString());
        }

        private void ListenForClients()
        {
            this.tcpListener.Start();
            while (true)
            {
                try
                {
                    TcpClient client = this.tcpListener.AcceptTcpClient();
                    Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                    clientThread.Start(client);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Connection Error : " + ex.ToString());
                    break;
                }
            }
        }

        public void StopRunning()
        {
            tcpListener.Stop();
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            Console.WriteLine("Client @[{0}] connected @{1}", tcpClient.Client.LocalEndPoint, DateTime.Now.ToString());

            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[2048];
            int bytesRead;
            int leftBytes = 2048;

            while (true)
            {
                try
                {
                    bytesRead = clientStream.Read(message, 2048 - leftBytes, leftBytes);
                    if (bytesRead > 0)
                    {
                        if (bytesRead < 2048)
                            Console.WriteLine("Read Bytes : " + bytesRead);
                        leftBytes -= bytesRead;
                        if (leftBytes == 0)
                        {
                            if (message[0] == 0x01 && message[1] == 0x23 && message[2] == 0x45 && message[3] == 0x67)
                                Form1.cardQueue.Enqueue(message);
                            else if (message[0] != 0xA5 && message[1] == 0x5A && message[2] == 0xA5 && message[3] == 0x5A)
                                Console.WriteLine("Error Head");
                            message = new byte[2048];
                            leftBytes = 2048;
                        }
                    }
                    else if (bytesRead <= 0)
                    {
                        Console.WriteLine("Client @[{0}] disconnect @{1}", tcpClient.Client.LocalEndPoint, DateTime.Now.ToString());
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Receive Msg Error : " + ex.ToString());
                    break;
                }
            }
            tcpClient.Close();
        }
    }
}