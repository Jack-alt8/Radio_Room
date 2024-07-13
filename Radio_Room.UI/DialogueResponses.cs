using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Radio_Room.UI.Components.Pages;
using Radio_Room.UI.DataControllers;
using Radio_Room.UI.dbContext;
using SQLitePCL;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;


namespace Radio_Room.UI
{
    
    public class DialogueResponses
    {
        private static Radio_RoomDbContext _context = new Radio_RoomDbContext();

        private static void Main(string[] args)
        {
            AddDialogues();
            GetDialogues();
            Console.WriteLine("Press any key...");
            Console.ReadKey();
            
        }
        private static void AddDialogues(params string[] dialogueLines)
        {
            foreach (string dialogueLine in dialogueLines)
            {
                _context.Dialogues.Add(new Dialogue { DialogueLine = "Hello?", DialogueId = 0 });
            }
            _context.SaveChanges();
        }

        private static void GetDialogues(params string[] dialogueLines)
        {
            var dialogues = _context.Dialogues
                .TagWith("Radio_Room.UI.GetDialogues method")
                .ToList();
                
            
            foreach (var dialogueLine in dialogueLines)
            {
                dialogues.Where(d => d.PlayerResponseOption == 1);
            };
            _context.SaveChanges();
        }

        
    


    /*Dialogue code (24lines)*/

    private string DialogueLine1 = "Hello?";

        private string DialogueLine2 = "Hello? Can anyone read me?";

        private string DialogueLinePath1_1 = "This is British Armed Forces Private Ben Matthew." +
            "Can't tell you how much of a relief it is to hear from someone on the outside!";

        private string DialogueLinePath1_2 = "Listen I'm stuck in Dunkirk, FR - " +
            "we're pinned against the Nazis and the ocean with the French and no present way out.";

        private string DialogueLinePath1_3 = "Most of us have managed to get out, " +
            "but the rest of us are getting slaughtered out here.";

        private string DialogueLinePath1_4 = "Could you help me?";

        private string DialogueLinePath2_1 = "Oh! Great! I can't tell you how much of a relief it is " +
            "to hear from someone on the outside! " +
            "This is British Armed Forces Private Ben Matthew by the way.";

        private string DialogueLinePath2_2 = "Listen I'm stuck in Dunkirk, FR - " +
            "we're pinned against the Nazis and the ocean with the French and no present way out.";

        private string DialogueLinePath2_3 = "Most of us have managed to get out, " +
            "but the rest of us are getting slaughtered out here.";

        private string DialogueLinePath2_4 = "Could you help me?";

        private string DialogueLinePath1A_1 = "I am in a tall brick building, " +
            "hiding out in a kitchen of what was some sort of restaurant or bakery.";

        private string DialogueLinePath1A_2 = "I ran 5 blocks from the shore " +
            "after I realized I wouldn't be able to get on the escape boats.";

        private string DialogueLinePath1A_3 = "And that's whe my squad got annihilated by " +
            "German troops hiding out in the buildings.";

        private string DialogueLinePath1A_4 = "What should I do now?";

        private string DialogueLinePath1B_1 = "Yeah, after I realized I wouldnt be able to get on " +
            "the escape boats, " +
            "me and my squad ran back inland.";

        private string DialogueLinePath1B_2 = "We were attacked by troops waiting in buildings. " +
            "Friends left and right were knocked clean off of their feet. " +
            "somehow I just keep running forward, " +
            "and then dodged behind the first building that looked unoccupied " +
            "and when the gun clamor became distant.";

        private string DialogueLinePath1B_3 = "What should I do now?";

        private string DialogueLinePath2A_1 = "What?! Man, we're wasting time here! " +
            "The German troops are only 5 blocks away from me (between me and the ocean). " +
            "I need help right now!";

        private string DialogueLinePath2A_2 = "There's no time for this!";

        private string DialogueLinePath2A_3 = "I can't remember every minute detail" +
            " when I've been focused on getting out of here! I need help! How can I get out of here?";

        private string DialogueLinePath2B_1 = "Look, all I know is people started rushing to those boats, " +
            "and without explanation some of those went ahead and left...";

        private string DialogueLinePath2B_2 = "There was some mention of troops to be left behind so the rest could escape, " +
            "but before any orders were given... German soldiers started coming out of the woodwork " +
            "like they were waiting for us to be left for them.";

        private string DialogueLinePath2B_3 = "And we were man, my squad, " +
            "the 16th was the furthest back and got annihilated.";

        private string DialogueLinePath2B_4 = "The sole reason I survived is by running to the " +
            "left and I kept running...";

        private string DialogueLinePath2B_5 = "Then ran inland 5 blocks til I couldn't hear gunshots as closely.";

        private string DialogueLinePath2B_6 = "Dove into this abandoned restaurant building.";

        private string DialogueLinePath2B_7 = "Now I'm hiding in the kitchen.";

        private string DialogueLinePath2B_8 = "What should I do?";

        
        

        
    }

    

    
}
