# EasyCommand

## Installation
EasyCommand.AspNetCore is in pre-release and is available as a [NuGet package](https://www.nuget.org/packages/EasyCommand.AspNetCore/1.0.0-CI-20180821-153641).

## What's this?
EasyCommand trivialises the use of the command pattern in .NET Core and ASP.NET Core.

```csharp
this.ExecuteAsync(this.Command<GetCommand>());
```

It is an opinionated, light, command pattern framework.

```csharp
public class GetCommandParamId : AsyncAspCommand<int, string>
{
    protected override Task<string> ExecuteCommandAsync(int request)
    {
        return Task.FromResult("value");
    }
}
```

You can execute commands straight from an ASP.NET Core controller.

```
[HttpGet]
public async Task<ActionResult<IEnumerable<string>>> Get()
{
    return await this.ExecuteAsync(this.Command<GetCommand>());
}
```

You can call commands from other commands.

```csharp
public class FirstCommand : AsyncAspCommand<int, int>
{
    protected override async Task<int> ExecuteCommandAsync(int request)
    {
        return await this.ExecuteAsync(this.Command<SecondCommand>(), request);
    }
}
```

As with ASP.NET controllers, EasyCommand supports the .NET Core service dependency registration and injection model.

```csharp
public class SecondCommand : AsyncAspCommand<int, int>
{
    private readonly IRandomService randomService;

    public SecondCommand(IRandomService randomService)
    {
        this.randomService = randomService;
    }

    protected override Task<int> ExecuteCommandAsync(int request)
    {
        return Task.FromResult(request + randomService.Next());
    }
}
```
