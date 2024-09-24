using Spectre.Console;
using Figgle;
using SharpConfig;
using CommandLine;

namespace DustToDust;

/*
 * SpectreConsole for pretty Console
 * Figgle for ascii art, mainly the title
 * SharpConfig to make configuration easier
 * CommandLineParser to handle input better
 */

class Program
{
    private static void Main(string[] args)
    {
        WelcomeMessage(args);
    }

    private static void WelcomeMessage(string[] args)
    {
        var ascii = FiggleFonts.Computer.Render("Dust To Dust");
        var title = new Markup($"\n\n[red]{ascii}[/]\n\n").Centered();
        Console.Clear();
        AnsiConsole.Write(title);

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What do you want to do?")
                .PageSize(10)
                .HighlightStyle(Style.Plain)
                .AddChoices(new[] { "Log In", "About", "Exit" }));

        Console.WriteLine($"You chose {choice}");
    }
}