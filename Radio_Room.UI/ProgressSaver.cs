using MudBlazor.Charts;
using System.IO;

namespace Radio_Room.UI
{
    // Collect all the dialogues in a list
    // iterate over that list
    // put that as plain text in a txt file

    public class ProgressSaver
    {
        static Environment.SpecialFolder folder = Environment.SpecialFolder.Desktop;
        static string path = Environment.GetFolderPath(folder);
        public static void CopyFile(IEnumerable<int> savedResponseOptions)
        {
            
            File.WriteAllLines(path + "\\Progress.txt", savedResponseOptions.Select(z => z.ToString()));
            
        }

        public static IEnumerable<int> ReadFile() 
        {
            return File.ReadAllLines(path + "\\Progress.txt").Select(z => Int32.Parse(z));
        }

    }
}
