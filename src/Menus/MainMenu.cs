using Spectre.Console;

namespace DustToDust.Menus;

public static class MainMenu
{
    public static void WelcomeMessage()
    {
        Console.Clear();
        AnsiConsole.Write(Globals.Title);

        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .Title("What do you want to do?")
                .PageSize(10)
                .HighlightStyle(Style.Plain)
                .AddChoices("Log In", "About", "Exit"));

        switch (choice)
        {
            case "Log In":
                break;
            case "About":
                About();
                break;
            case "Exit":
                Exit();
                break;
        }
    }

    private static void About()
    {
        Console.Clear();
        AnsiConsole.Write(Globals.Title);
        var text = new Markup(
            "[italic red]Dust To Dust[/]\n" +
            "is a text-based role-playing game,\n" +
            "in which you play as the pilot of a military spaceship.\n" +
            "You are en route to the conflict zone.\n\n" +
            "[italic]This game covers topics like existence, morality and violence\n" +
            "[red]If you are sensitive about said topics, this game might not be for you[/][/]\n\n" +
            "Enjoy.")
            .Centered();
        AnsiConsole.Write(text);
        Console.ReadKey(true);
    }

    private static void Exit()
    {
        Console.Clear();
        AnsiConsole.Write(Globals.Title);
        var text = new Markup("[red]See you around[/]").
            Centered(); // TODO: Custom messages based on current story
        AnsiConsole.Write(text);
        Console.ReadKey(true);
        Console.Clear();
        Environment.Exit(0);
    }
}