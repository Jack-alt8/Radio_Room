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
        // Collect all the dialogues in a list
        // iterate over that list
        // put that as plain text in a txt file
        private const int NumberOfRetries = 3;
        private const int DelayOnRetry = 1000;
        
        public static void StartFileWrite()
        {
            for (int i = 1; i <= NumberOfRetries; i++) 
            {
                try
                {
                    // Do stuff with file
                    using (var stream = File.Open("Components\\Pages\\Home.razor", FileMode.Open, FileAccess.Write, FileShare.Read))
                    {
                    ConvertHtml();
                    }
                    //break;
                }
                catch (IOException e) when (i <= NumberOfRetries)
                {
                    // You may check error code to filter some exceptions, not every error
                    // can be recovered.
                    
                    Thread.Sleep(DelayOnRetry);
                }
            }
        }
        
           public static void ConvertHtml()
           {

                //using (var stream = File.Open("Components\\Pages\\Home.razor", FileMode.Open, FileAccess.Write, FileShare.Read))
                //{

                    // Load your HTML content (e.g., from a file or a web request)
                    HtmlDocument doc = new HtmlDocument();
                    doc.Load("Components\\Pages\\Home.razor");

                    // Destination file to write text
                    StreamWriter writer = new StreamWriter("Save\\Progress.txt");

                    // Select all <p> elements and buttons
                    var paragraphs = doc.DocumentNode.SelectNodes("//p");

                    if (paragraphs != null)
                    {
                        foreach (var paragraph in paragraphs)
                        {
                            string paragraphText = paragraph.InnerText;

                            // Process the paragraph text as needed

                            File.WriteAllText("Save\\Progress.txt", paragraphText);
                            writer.WriteLine(paragraphText);
                        }
                        writer.Close();
                        
                    }

                //}
            
           }
    
    }
}

/*
            private const int NumberOfRetries = 3;
            private const int DelayOnRetry = 1000;

                    for (int i=1; i <= NumberOfRetries; ++i) 
                    {
                        try {
                            // Do stuff with file
                            private ConvertHtml();
                            break; // When done we can break loop
                        }
                        catch (IOException e) when(i <= NumberOfRetries)
                        {
                        // You may check error code to filter some exceptions, not every error
                        // can be recovered.
                        Thread.Sleep(DelayOnRetry);
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


