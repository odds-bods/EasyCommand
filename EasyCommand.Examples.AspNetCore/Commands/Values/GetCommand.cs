using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class GetCommand : AspCommandNoRequest<string[]>
    {
        protected override string[] Execute(EmptyCommandRequest request)
        {
            return new string[] { "value1", "value2" };
        }
    }
}
