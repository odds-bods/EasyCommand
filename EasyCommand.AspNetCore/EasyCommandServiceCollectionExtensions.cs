using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;

namespace EasyCommand.AspNetCore
{
    public static class EasyCommandServiceCollectionExtensions
    {
        public static IServiceCollection AddEasyCommand(this IServiceCollection services, object assemblyObject, Action<CommandRunningConfiguration> buildConfiguration = null)
        {
            var types = assemblyObject.GetType().Assembly.GetTypes();

            return SetupEasyCommand(services, types, buildConfiguration);

        }

        public static IServiceCollection AddEasyCommand(this IServiceCollection services, Action<CommandRunningConfiguration> buildConfiguration = null)
        {
            var types = Assembly.GetCallingAssembly().GetTypes();

            return services.SetupEasyCommand(types, buildConfiguration);
        }

        private static IServiceCollection SetupEasyCommand(this IServiceCollection services, IEnumerable<Type> allTypes, Action<CommandRunningConfiguration> buildConfiguration = null)
        {
            services.RegisterCommands(allTypes);

            if (buildConfiguration is null)
                return services;

            var configuration = new CommandRunningConfiguration();
            buildConfiguration(configuration);

            services.RegisterHandlers();

            return services;
        }

        private static void RegisterCommands(this IServiceCollection services, IEnumerable<Type> allTypes)
        {
            var types = allTypes.Where(t =>
            typeof(IAsyncCommand).IsAssignableFrom(t));

            foreach (var type in types)
            {
                services.AddTransient(type);
            }
        }

        private static void RegisterHandlers(this IServiceCollection services)
        {
            if (CommandRunningConfiguration.Handlers is null) return;
            for (var i = 0; i < CommandRunningConfiguration.Handlers.Length; i++)
            {
                services.AddTransient(CommandRunningConfiguration.Handlers[i], CommandRunningConfiguration.Handlers[i]);
            }
        }
    }
}
