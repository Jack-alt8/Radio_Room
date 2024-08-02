using Microsoft.EntityFrameworkCore;
using Radio_Room.UI.dbContext;

namespace Radio_Room.UI
{
    public interface IDialogueService
    {
        Task<List<Dialogue>> GetAllDialogues();
    }

    public class DialogueService : IDialogueService
    {
        public async Task<List<Dialogue>> GetAllDialogues()
        {
            using (var context = new Radio_RoomDbContext())
            {
                return await context.Dialogues.ToListAsync();
            }
        }

    }
}
