using Microsoft.EntityFrameworkCore;
using Radio_Room.UI;


namespace Radio_Room.UI.dbContext
{
    public class Radio_RoomDbContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase/Dialogues.db");
        }

        public DbSet<Dialogue> dialogues { get; set; }
    }
}
