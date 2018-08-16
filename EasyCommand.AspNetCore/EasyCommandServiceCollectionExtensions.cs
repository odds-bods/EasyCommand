using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EasyCommand.AspNetCore
{
    public static class EasyCommandServiceCollectionExtensions
    {
        public static IServiceCollection AddEasyCommand(this IServiceCollection services, object context)
        {
            var types = context.GetType().Assembly.GetTypes();

            var commandsRegistered = new List<Type>();

            foreach (var type in types)
            {
                var interfaces = type.GetInterfaces();

                // TODO: Strongly type.
                if (interfaces.FirstOrDefault(x => x.Name.StartsWith("IAsyncCommand")) != null)
                {
                    services.AddTransient(type);
                    commandsRegistered.Add(type);
                }
            }

            return services;
        }
    }
}
