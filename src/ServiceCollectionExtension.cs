using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ArbreSoft.Logging
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddLogging(this IServiceCollection serviceCollection,
            IConfiguration configuration)
        {
            return serviceCollection
                .AddSingleton<ConsoleLogger>()
                .Configure<FileLoggerConfig>(configuration.GetSection(typeof(FileLoggerConfig).Name))
                .AddSingleton<FileLogger>()
                .AddSingleton<LocalLogger>(serviceProvider =>
                {
                    var loggers = new List<Logger>() {
                        serviceProvider.GetRequiredService<ConsoleLogger>(),
                        serviceProvider.GetRequiredService<FileLogger>()};
                    return new LocalLogger(loggers);
                })

                .AddSingleton<DataBaseLogger>()
                .Configure<EmailLoggerConfig>(configuration.GetSection(typeof(EmailLoggerConfig).Name))
                .AddSingleton<EmailLogger>()
                .AddSingleton<RemoteLogger>(serviceProvider =>
                {
                    var loggers = new List<Logger>() {
                        serviceProvider.GetRequiredService<DataBaseLogger>(),
                        serviceProvider.GetRequiredService<EmailLogger>()};
                    return new RemoteLogger(loggers);
                })

                .AddSingleton<Logger>(serviceProvider =>
                {
                    var loggers = new List<Logger>() {
                        serviceProvider.GetRequiredService<LocalLogger>(),
                        serviceProvider.GetRequiredService<RemoteLogger>()};
                    return new LoggerRoot(loggers);
                });
        }
    }
}