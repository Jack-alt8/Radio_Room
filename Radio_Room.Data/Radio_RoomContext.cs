using Microsoft.EntityFrameworkCore;

namespace Radio_Room.Data
{
    public class Radio_RoomContext : DbContext
    {
        public DbSet<Dialogue> Dialogues { get; set; }
    }
}
