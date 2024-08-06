using MudBlazor.Charts;
using System.IO;

namespace Radio_Room.UI
{
    // functionality for save and load buttons
    public class ProgressSaver
    {
        static Environment.SpecialFolder folder = Environment.SpecialFolder.Desktop;
        static string path = Environment.GetFolderPath(folder);
        public static async Task CopyFileAsync(IEnumerable<int> savedResponseOptions)
        {
            File.Delete(path + "\\Progress.txt");
            await File.WriteAllLinesAsync(path + "\\Progress.txt", savedResponseOptions.Select(z => z.ToString()));
            
        }

        public static async Task<IEnumerable<int>> ReadFileAsync() 
        {
            return (await File.ReadAllLinesAsync(path + "\\Progress.txt")).Select(z => Int32.Parse(z));
        }

    }
}
