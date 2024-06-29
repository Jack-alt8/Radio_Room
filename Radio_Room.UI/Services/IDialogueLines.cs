using Radio_Room.UI.dbContext;

namespace Radio_Room.UI.Services
{
    public interface IDialogueLines
    {
        Task AddNewDialogue(Dialogue dialogue);

    }
    public class DialogueLines : IDialogueLines
    {
        public async Task AddNewDialogue(Dialogue dialogue)
        {
            using (var context = new Radio_RoomDbContext())
            {
               await context.dialogues.AddAsync(dialogue);
                await context.SaveChangesAsync();
            }
        }
    }
}
