namespace HostServices;
internal sealed class BackGroundService(IServiceScopeFactory serviceScopeFactory) : BackgroundService
{
    private IServiceScopeFactory _serviceScopeFactory { get; } = serviceScopeFactory;

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        var peridoicTimer = new PeriodicTimer(TimeSpan.FromSeconds(5));

        while (!stoppingToken.IsCancellationRequested 
            && await peridoicTimer.WaitForNextTickAsync())
        {
            using AsyncServiceScope scope = _serviceScopeFactory.CreateAsyncScope();
            ILogger? logger = scope.ServiceProvider.GetService<ILogger<BackGroundService>>();
            logger?.LogInformation("Hello from background service");
        }
    }
}
