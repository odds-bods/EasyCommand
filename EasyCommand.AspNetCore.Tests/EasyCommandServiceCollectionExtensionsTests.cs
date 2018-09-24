using EasyCommand.AspNetCore.Tests.Commands;
using EasyCommand.AspNetCore.Tests.Handler;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using Xunit;

namespace EasyCommand.AspNetCore.Tests
{
    public class EasyCommandServiceCollectionExtensionsTests
    {
        [Fact]
        public void SuccessfullyRegistersCommand_NoOptions()
        {
            var services = CreateServiceProvider(
                    t => t.AddEasyCommand());

            var command = services.GetService<ExampleCommandWithRequestAndResult>();

            Assert.NotNull(command);
        }

        [Fact]
        public void SuccessfullyRegistersCommand_WithObject()
        {
            var services = CreateServiceProvider(
                    t => t.AddEasyCommand(new Startup(null)));

            var command = services.GetService<ExampleCommandWithRequestAndResult>();

            Assert.NotNull(command);
        }

        [Fact]
        public void SuccessfullyRegistersCustomHandler()
        {
            var services = CreateServiceProvider(
                    t => t.AddEasyCommand(c=>c.AddControllerCommandHandler<ExampleHandler>()));

            var runBeforeComamnds = services.GetServices<ExampleHandler>();

            Assert.NotNull(runBeforeComamnds);
            Assert.Contains(runBeforeComamnds, t => t.GetType() == typeof(ExampleHandler));
        }

        private IServiceProvider CreateServiceProvider(Action<IServiceCollection> addServices)
        {
            return new WebHostBuilder().UseStartup<Startup>().ConfigureTestServices(addServices).Build().Services;
        }
    }
}
