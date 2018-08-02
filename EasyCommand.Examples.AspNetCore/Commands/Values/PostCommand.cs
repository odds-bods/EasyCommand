using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class PostCommand : AspCommand<string, EmptyCommandResult>
    {
        protected override EmptyCommandResult Execute(string request)
        {
            return default(EmptyCommandResult);
        }
    }
}
