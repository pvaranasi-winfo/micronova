var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();

var config = builder.Configuration;

builder.Services
    .AddApplicationInsightsTelemetryWorkerService()
   .ConfigureFunctionsApplicationInsights();

builder.Services.AddHttpClient<ExternalClient>(async (sp, client) =>
{
    var secretClient = sp.GetRequiredService<SecretClient>();
    var secret = await secretClient.GetSecretAsync("ExternalApiBaseUrl");
    client.BaseAddress = new Uri(secret.Value.Value);
    client.DefaultRequestHeaders.Add("Accept", "application/json");
});

builder.Services.AddAzureClients(_ =>
{
    _.AddSecretClient(new Uri(config["KV:Endpoint"]!)).WithCredential(new DefaultAzureCredential());
    _.ConfigureDefaults(c =>
    {
        c.Retry.MaxRetries = 3;
        c.Retry.Mode = Azure.Core.RetryMode.Exponential;
    });
});

builder.UseMiddleware<GlobalExceptionMiddleware>();


builder.UseDefaultWorkerMiddleware();

builder.Build().Run();