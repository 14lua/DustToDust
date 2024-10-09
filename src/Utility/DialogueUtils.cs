using Spectre.Console;

namespace DustToDust.Utility;

public static class DialogueUtils
{
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
    }}