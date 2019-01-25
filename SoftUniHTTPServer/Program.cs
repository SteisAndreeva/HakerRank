using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftUniHTTPServer
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            IHttpServer server = new HTTPServer();

            server.Start();
        }
    }

    public class HTTPServer : IHttpServer
    {
        private bool isWorking;
        private TcpListener tcpListener;

        public HTTPServer()
        {
            this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
        }

        public void Start()
        {
            this.isWorking = true;
            this.tcpListener.Start();

            while (this.isWorking)
            {
                var client = this.tcpListener.AcceptTcpClient();
                Task.Run(() => ProcessClient(client));
            }
        }

        private static async void ProcessClient(TcpClient client)
        {
            var buffer = new byte[10240];
            var stream = client.GetStream();
            var readLength = await stream.ReadAsync(buffer, 0, buffer.Length);
            var requestText = Encoding.UTF8.GetString(buffer, 0, readLength);
            Console.WriteLine(new string('*', 60));
            Console.WriteLine(requestText);
            var responseText = "<h1>Hello!</h1>some text";
            var responseBytes = Encoding.UTF8.GetBytes(
                "HTTP/1.0 200 OK" + Environment.NewLine +
                "Content-Length: " + responseText.Length + Environment.NewLine + Environment.NewLine +
                responseText);
            await stream.WriteAsync(responseBytes, 0, responseBytes.Length);
        }

        public void Stop()
        {
            this.isWorking = false;
        }
    }

    public interface IHttpServer
    {
        void Start();

        void Stop();
    }
}