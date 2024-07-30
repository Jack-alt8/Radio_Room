using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Radio_Room.UI.dbContext;


namespace Radio_Room.UI
{
    public class DbInitializer
    {
        private readonly Radio_RoomDbContext dataContext;
        private string connectionString;

        public DbInitializer(Radio_RoomDbContext context)
        {
            this.dataContext = context;
        }

        public void Initialize(string connectionString)
        {
            this.connectionString = connectionString;

            try
            { 
                if (dataContext.Dialogues.Any())
                {
                    ClearDialogues();
                    InitializeDialogues();
                }
            }
            catch (ArgumentException ex)
            {
                
            }
        }

        private void ClearDialogues()
        {
            var dbDialogues = dataContext.Dialogues.Find(1-28);
            dataContext.Dialogues.RemoveRange(dbDialogues);
            dataContext.SaveChanges();
        }

        private void InitializeDialogues()
        {
            IEnumerable<Dialogue> dialogues = GetDialoguesFromExternalDatabase();
            dataContext.Dialogues.AddRange(dialogues);
            var result = dataContext.SaveChanges();
            Console.WriteLine($"Result: {result}");
        }

        public class DialogsList { public List<Dialogue> Dialogues = []; };

        private IEnumerable<Dialogue> GetDialoguesFromExternalDatabase() 
        {
            string pathToDialogueJson = "Dialogues.json";
            string jsonString = File.ReadAllText(pathToDialogueJson);
            var dialogues = JsonConvert.DeserializeObject<DialogsList>(jsonString);
                
            return dialogues.Dialogues;

        }

    }
}
