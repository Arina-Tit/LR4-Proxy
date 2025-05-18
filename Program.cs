using System;
using System.Net;
using System.Threading.Tasks;

namespace proxy
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int port = 8080; // Порт по умолчанию
            IPAddress proxyAddress = IPAddress.Parse("127.0.0.2");
            
            if (args.Length > 0 && int.TryParse(args[0], out int customPort))
            {
                port = customPort;
            }
            
            Console.WriteLine($"Запуск прокси-сервера на {proxyAddress}:{port}");
            Console.WriteLine("Нажмите Ctrl+C для остановки сервера");
            
            var proxyServer = new SimpleProxyServer(port, proxyAddress);
            
            // Обработка сигнала прерывания (Ctrl+C)
            Console.CancelKeyPress += (sender, e) => {
                e.Cancel = true;
                proxyServer.Stop();
            };
            
            await proxyServer.StartAsync();
        }
    }
}
