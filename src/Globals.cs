using Figgle;
using Spectre.Console;

namespace DustToDust;

public static class Globals
{
    public static string UsrName { get; set; } = "Yonah";
    private static readonly string Ascii = FiggleFonts.Computer.Render("Dust To Dust");
    public static Markup Title = new Markup($"\n\n[red]{Ascii}[/]\n\n").Centered();
}