using Typin.Attributes;
using Typin.Console;
using Typin;
using Microsoft.Extensions.DependencyInjection;
using Typin.Directives;
using Typin.Modes;
using Sharprompt;

// https://github.com/shibayan/Sharprompt for the win
namespace consoleApp;

class Program
{

   
    public static async Task<int> Main() {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(DataSec.CreateMD5("Hello, World!"));
        Console.WriteLine(DataSec.CreateSHA256("Hello, World!"));
        string encrypted = DataSec.Encrypt("123456789");
        Console.WriteLine(encrypted);
        Console.WriteLine(DataSec.Decrypt(encrypted));
        var name = Prompt.Input<string>("What's your name?");
        var number = Prompt.Input<int>("Enter any number");

        return await new CliApplicationBuilder()
                //.UseStartup<CliStartup>()
                .AddCommandsFromThisAssembly()
                .UseInteractiveMode()
                .Build()
                .RunAsync();

    }

    




    
}

public class CliStartup : ICliStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // Register services
        //services.AddSingleton<ICustomService, CustomService>();
    }

    public void Configure(CliApplicationBuilder app)
    {
        app.AddCommandsFromThisAssembly()
           .AddDirective<DebugDirective>()
           .AddDirective<PreviewDirective>()
           .UseInteractiveMode();
    }
}

[Command]
public class HelloWorldCommand : ICommand
{
    public async ValueTask ExecuteAsync(IConsole console)
    {
        await console.Output.WriteLineAsync("Hello world!");
    }
}
