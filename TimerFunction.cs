

namespace TimerFunction;
public class TimerFunction
{
    private readonly ILogger _logger;
    private readonly ExternalClient _externalClient;
    private readonly ApiSettings _apiSettings;

    private readonly DataFetcher _dataFetcher;
    public TimerFunction(ExternalClient externalClient, IOptions<ApiSettings> apiSettings, ILoggerFactory loggerFactory)
    {
        _logger = loggerFactory.CreateLogger<TimerFunction>();
        _externalClient = externalClient;
        _apiSettings = apiSettings.Value;
        _dataFetcher = new DataFetcher();
        //TODO: Subscriber to data fetcher
    }

    [Function("TimerFunction")]
    public async Task Run([TimerTrigger("0 */5 * * * *")] TimerInfo myTimer)
    {
        var data = await _externalClient.GetDataAsync();
        //TODO: next stages of api call

    }
}