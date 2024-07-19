using Microsoft.EntityFrameworkCore;
using Radio_Room.UI;


namespace Radio_Room.UI.dbContext
{
    public class Radio_RoomDbContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("ConnectionStrings:SQLiteDefault");
        }

        public DbSet<Dialogue> Dialogues { get; set; }
    }
}
