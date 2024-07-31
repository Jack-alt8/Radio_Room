using Microsoft.EntityFrameworkCore;
using Radio_Room.UI.dbContext;

namespace Radio_Room.UI
{
    public interface IDialogueService
    {
        List<Dialogue> GetAllDialogues();
    }

    public class DialogueService : IDialogueService
    {
        public List<Dialogue> GetAllDialogues()
        {
            using (var context = new Radio_RoomDbContext())
            {
                return context.Dialogues.ToList();
            }
        }

    }
}
