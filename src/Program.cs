using DustToDust.Menus;

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
        Console.SetWindowSize(80, 25);
        Console.SetBufferSize(80, 25);
        MainMenu.WelcomeMessage();
    }
}