using Microsoft.AspNetCore.ResponseCaching;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query.Internal;
using MudBlazor;
using Radio_Room.UI.Components.Pages;
using Radio_Room.UI.dbContext;
using SQLitePCL;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


namespace Radio_Room.UI
{

    public class DialogueResponsesData : Dialogue
    {
        public List<DialogueResponses> dialogueResponses = new List<DialogueResponses>();
        private readonly Radio_RoomDbContext dataContext;
        string connectionString = "ConnectionStrings:SQLiteDefault";

        public DialogueResponsesData(Radio_RoomDbContext context) => this.dataContext = context;

        public void Respond(string connectionString)
        {
            this.connectionString = connectionString;
            if (!dataContext.Dialogues.Any())
            {
                DialogueQueryFilters();
            }
            
        }
        public void DialogueQueryFilters()
        {
            //var dialogueResponse = dataContext.Dialogues.Find(0);
            var playerResponse = int.Parse("1"); //this needs to grab from the Home buttons
            var dialogueResponse = dataContext.Dialogues.Where(s => s.PlayerResponseOption == playerResponse).ToList(); //this needs to be put into the p tags in home
        }
    }



    public class DialogueResponses
    {
        public int DialogueId;
        public string DialogueLine;
        public int PlayerResponseOption;
    }
        
}
