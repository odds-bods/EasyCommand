using EasyCommand.AspNetCore;

namespace EasyCommand.Examples.AspNetCore.Commands.Values
{
    public class PutCommand : AspCommand<PutCommandRequest, EmptyCommandResult>
    {
        protected override EmptyCommandResult Execute(PutCommandRequest request)
        {
            return default(EmptyCommandResult);
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
