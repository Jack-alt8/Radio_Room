using Microsoft.AspNetCore.ResponseCaching;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Radio_Room.UI.Components.Pages;
using Radio_Room.UI.dbContext;
using SQLitePCL;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace Radio_Room.UI
{
    
    public class DialogueResponsesData
    {

        private readonly Radio_RoomDbContext dataContext;
        private string connectionString;
        /*
        public DbResponder(Radio_RoomDbContext context)
        {
            this.dataContext = context;
        }

        private void Respond(string connectionString)
        {
            this.connectionString = connectionString;
            if (!dataContext.Dialogues.Any())
            {
                ResponseDialogues();
            }
        }

        

        private static void ResponseDialogues()
        {
            IEnumerable<Dialogue> dialogues = GetDialogueFromDialoguesDatabase();
            dataContext.Dialogues.GetAsyncEnumerator(dialogues);
            var result = dataContext.SaveChanges();
            Console.WriteLine($"Result: {result}");
        }

        public class DialogsList { public List<Dialogue> Dialogues = []; };

        private IEnumerable<Dialogue> GetDialogueFromDialoguesDatabase()
        {
            string pathToDialogue = "Data Source=DataBase/Dialogues.db";

            var dialogues = ResponseOption;

            return dialogues.Dialogues;

        }*/
    }

    

    
}
