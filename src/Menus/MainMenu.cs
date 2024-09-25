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
                .HighlightStyle(Style.Plain)
                .AddChoices("Log In", "About", "Exit"));

        switch (choice)
        {
            case "Log In":
                LogIn();
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

    private static void LogIn()
    {
        Console.Clear();
        Thread.Sleep(1000);
        BottomLeftAnimated("15:40:06 UTC\nArriving at Jupiter AO");
        Hear("*cockpit door knocks repeatedly*");
        Talk(Prompt(["What?", "No.", "*ignore*"]));
        Console.ReadKey(true);
    }

    public static void BottomLeftAnimated(string prompt)
    {
        Console.Clear();
        var windowWidth = Console.WindowWidth;
        var windowHeight = Console.WindowHeight;
        Console.SetCursorPosition(0, windowHeight - 5);
        foreach (var c in prompt)
        {
            AnsiConsole.Markup($"[italic bold]{c}[/]");
            Thread.Sleep(25);
        }
        Thread.Sleep(1000);
        Console.Clear();
        Console.SetCursorPosition(0, 0);
    }

    public static void Hear(string dialogue)
    {
        Console.Clear();
        Globals.SetHearCursor();
        foreach (var c in dialogue)
        {
            AnsiConsole.Markup($"[italic]{c}[/]");
            Thread.Sleep(20);
        }
        Thread.Sleep(500);
    }

    public static void Talk(string dialogue)
    {
        Globals.SetTalkCursor();
        AnsiConsole.Markup(">> ");
        foreach (var c in dialogue)
        {
            AnsiConsole.Markup($"{c}");
            Thread.Sleep(20);
        }
    }

    public static string Prompt(string[] options)
    {
        Globals.SetPromptCursor();
        var choice = AnsiConsole.Prompt(
            new SelectionPrompt<string>()
                .HighlightStyle(Style.Plain)
                .AddChoices(options));
        return choice;
    }
}