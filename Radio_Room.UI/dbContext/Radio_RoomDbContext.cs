using Microsoft.EntityFrameworkCore;
using Radio_Room.UI;
using Radio_Room.UI.DataControllers;


namespace Radio_Room.UI.dbContext
{
    public class Radio_RoomDbContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase/Dialogues.db");
        }

        public DbSet<Dialogue> Dialogues { get; set; }
    }
}
