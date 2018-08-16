using EasyCommand.AspNetCore;
using System.Threading.Tasks;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class PutCommand : AsyncAspCommand<PutCommandRequest, EmptyCommandResult>
    {
        protected override Task<EmptyCommandResult> ExecuteAsync(PutCommandRequest request)
        {
            return Task.FromResult(default(EmptyCommandResult));
        }
    }

    public class PutCommandRequest
    {
        public PutCommandRequest(int id, string value)
        {
            Id = id;
            Value = value;
        }

        public int Id { get; }
        public string Value { get; }
    }
}
