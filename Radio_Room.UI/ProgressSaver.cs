﻿using Radio_Room.UI.Components.Pages;
using System.IO;
using System.Text;
using HtmlAgilityPack;
using System.Reflection.PortableExecutable;

namespace Radio_Room.UI
{
    public class ProgressSaver
    {
        public static void ConvertHtml()
        {
            // Load your HTML content (e.g., from a file or a web request)
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml("Components//Pages//Welcome.razor");

            // Destination file to write text
            StreamWriter writer = new StreamWriter("Save//Progress.txt");

            // Select all <p> elements and buttons
            var paragraphs = htmlDocument.DocumentNode.SelectNodes("//p");

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