using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace NetFramework.BackgroundTask
{
    internal class HostedService : IHostedService, IDisposable
    {
        private Timer Timer { get; set; }
        public void Dispose()
        {
            
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Timed Background Service is starting.");

            Timer = new Timer(DoWork, null, TimeSpan.Zero,
                TimeSpan.FromSeconds(10));

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Timed Background Service is stopping.");

            Timer?.Change(Timeout.Infinite, 0);

            return Task.CompletedTask;
        }
        private void DoWork(object state)
        {
            Console.WriteLine($"Timed Background Service is working. {DateTime.Now}");
             
        }
    }
}
