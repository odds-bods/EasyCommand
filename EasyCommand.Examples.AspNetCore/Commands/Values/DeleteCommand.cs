using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class DeleteCommand : AspCommandNoResult<int>
    {
        protected override EmptyCommandResult Execute(int request)
        {
            return EmptyResult;
        }
    }
}
