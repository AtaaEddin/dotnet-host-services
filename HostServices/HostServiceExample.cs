namespace HostServices
{
    internal sealed class HostServiceExample : IHostedLifecycleService
    {
        public Task StartAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Start host service");
            return Task.CompletedTask;
        }

        public Task StartedAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Started host service");
            return Task.CompletedTask;
        }

        public Task StartingAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Starting host service");
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stop host service");
            return Task.CompletedTask;
        }

        public Task StoppedAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopped host service");
            return Task.CompletedTask;
        }

        public Task StoppingAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Stopping host service");
            return Task.CompletedTask;
        }
    }
}
