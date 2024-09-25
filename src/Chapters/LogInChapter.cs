using static DustToDust.Utility.DialogueUtils;

namespace DustToDust.Chapters;

public static class LogInChapter
{
    public static void LogIn()
    {
        Console.Clear();
        Thread.Sleep(1000);
        BottomLeftAnimated("15:40:06 UTC\nArriving at Jupiter AO");
        Hear("*cockpit door knocks repeatedly*");
        Talk(Prompt(["What?", "No.", "*ignore*"]));
        Console.ReadKey(true);
    }
}