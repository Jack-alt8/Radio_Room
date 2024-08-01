using Radio_Room.UI.Components.Pages;
using System.IO;
using System.Text;
using HtmlAgilityPack;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.X509Certificates;

namespace Radio_Room.UI
{
    public class ProgressSaver
    {
        // Collect all the dialogues in a list then iterate over that list and put that as plain text in a txt file

        void CopyFileInChunks(int chunkSize, string srcFilePath, string destFilePath)
        {

            var srcFile = "Components//Pages//Home.razor";
            var destFile = "Save//Progress.txt";

            // create streams for source and target file
            using var reader = new FileStream(srcFile, FileMode.Open);
            using var writer = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.Write);

            // get how much bytes were read from the stream
            var readCount = 0;
            // the byte bucket to transfer data
            var buffer = new byte[chunkSize];

            // read bytes from source stream and write them into target stream
            while ((readCount = reader.Read(buffer, 0, buffer.Length)) != 0)
            {
                writer.Write(buffer, 0, readCount);
            }
        }
        public static void ConvertHtml()
        {
            var srcFile = "Components//Pages//Home.razor";
            var destFile = "Save//Progress.txt";

            using (var stream = File.Open(srcFile, FileMode.Open, FileAccess.Write, FileShare.Read))
            {
                // Clearing file before build
                File.Delete(destFile);

                // Writing all dialogue from p tags and buttons pressed by user
                //CopyFileInChunks(60, srcFile, destFile);
                
            }
        }

        
        /*
        public string ExtractElementById(string elementId)
        {
           
            var element = _razorComponent.ToHtmlString();
            // Implement your logic to extract the HTML element by ID
            // For example:
            // var extractedElement = "<div>Extracted Element</div>";
            var razorComponent = new HtmlString("<div id='myElement'>Hello, World!</div>");
            var extractor = new ProgressSaver(razorComponent);
            var extractedElement = extractor.ExtractElementById("myElement");
            return extractedElement;
        }
    

    // Usage
   
    Console.WriteLine(extractedElement);

        /*
        public static void ConvertHtml()
        {
            // Load your HTML content (e.g., from a file or a web request)
            HtmlDocument doc = new HtmlDocument();
            doc.Load("Components/Pages/Home.razor");

            // Destination file to write text
            StreamWriter writer = new StreamWriter("Save/Progress.txt");

            // Select all <p> elements and buttons
            var paragraphs = doc.DocumentNode.SelectNodes("//p");

            if (paragraphs != null)
            {
                foreach (var paragraph in paragraphs)
                {
                    string paragraphText = paragraph.InnerText;

                    // Process the paragraph text as needed

                    //File.WriteAllText("Save//Progress.txt", paragraphText);
                    writer.WriteLine(paragraphText);
                }
                writer.Close();
            }
        }
        */
        /*
        void CopyFileInChunks(int chunkSize, string srcFilePath, string destFilePath)
        {
            var srcFile = "Components//Pages//Home.razor";
            var destFile = "Save//Progress.txt";

            // create streams for source and target file
            using var reader = new FileStream(srcFile, FileMode.Open);
            using var writer = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.Write);
            
            // get how much bytes were read from the stream
            var readCount = 0;
            // the byte bucket to transfer data
            var buffer = new byte[chunkSize];

            // read bytes from source stream and write them into target stream
            while ((readCount = reader.Read(buffer, 0, buffer.Length)) != 0)
            {
                writer.Write(buffer, 0, readCount);
            }
        }*/
    }
}
