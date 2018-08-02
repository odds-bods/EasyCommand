using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class GetCommandParamId : AspCommand<int, string>
    {
        protected override string Execute(int request)
        {
            return "value";
        }
    }
}
