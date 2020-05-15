using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace TSXNetCoreClient
{
    public static class Link
    {
        const string TSXHost = "10.71.4.5";
        const int TSXPort = 3040;              // 3040 is the default, it can be changed
        const string CR = "\r\n";

        public static string TSXSend(string command)
        {
            //Generate special format
            string fullMessage = "/* Java Script */" + CR +
                "/* Socket Start Packet */" + CR + CR +
               command + ";" + CR + CR +
                "/* Socket End Packet */";

            ////Console.WriteLine("Socket: " + CR + fullMessage);
            // Establish the remote endpoint  
            // for the socket.
            IPHostEntry ipHost = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ipAddr = ipHost.AddressList[0];
            IPEndPoint localEndPoint = new IPEndPoint(ipAddr, TSXPort);

            // Creation TCP/IP Socket using  
            // Socket Class Costructor 
            Socket sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            string tsxIn = "";
            try
            {

                // Connect Socket to the remote  
                // endpoint using method Connect() 
                sender.Connect(localEndPoint);

                // We print EndPoint information  
                // that we are connected 
                ////Console.WriteLine("Socket: Socket connected to -> {0} ", sender.RemoteEndPoint.ToString());

                // Creation of messagge that 
                // we will send to Server 
                byte[] messageSent = Encoding.ASCII.GetBytes(fullMessage);
                int byteSent = sender.Send(messageSent);

                // Data buffer 
                byte[] messageReceived = new byte[1024];

                // We receive the messagge using  
                // the method Receive(). This  
                // method returns number of bytes 
                // received, that we'll use to  
                // convert them to string 
                int byteRecv = sender.Receive(messageReceived);
                tsxIn = Encoding.ASCII.GetString(messageReceived, 0, byteRecv);
                //Console.WriteLine("Socket: Message from Server -> " + tsxIn);
                tsxIn = (tsxIn.Split('|'))[0];

                // Close Socket using  
                // the method Close() 
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return tsxIn;
        }
    }
}
