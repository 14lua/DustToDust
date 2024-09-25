using Figgle;
using Spectre.Console;

namespace DustToDust;

public static class Globals
{
    public static string UsrName { get; set; } = "Yonah";
    private static readonly string Ascii = FiggleFonts.Computer.Render("Dust To Dust");
    public static readonly Markup Title = new Markup($"\n\n[red]{Ascii}[/]\n\n").Centered();

    public static void SetHearCursor(int offset = 0) => Console.SetCursorPosition(4, 1 + offset);
    public static void SetTalkCursor(int offset = 0) => Console.SetCursorPosition(4, 2);
    public static void SetPromptCursor() => Console.SetCursorPosition(0, 15);
    public static void SetDefaultCursor() => Console.SetCursorPosition(0, 0);
}