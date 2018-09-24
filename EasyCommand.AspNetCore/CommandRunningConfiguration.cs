using System;

namespace EasyCommand.AspNetCore
{
    public class CommandRunningConfiguration
    {
        internal static Type[] Handlers { get; private set; } = new Type[0];

        /// <summary>
        /// Sets the handler to use when executing commands from the controller base extension, this handler is not called when calling from command to command
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public CommandRunningConfiguration AddControllerCommandHandler<T>() where T : IAsyncAspCommandHandler
        {
            var newHandlers = new Type[Handlers.Length + 1];

            for (var i = 0; i < Handlers.Length; i++)
            {
                newHandlers[i] = Handlers[i];
            }

            newHandlers[Handlers.Length] = typeof(T);

            Handlers = newHandlers;

            return this;
        }
      
    }
}
