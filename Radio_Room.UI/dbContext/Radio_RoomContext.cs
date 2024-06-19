using Microsoft.EntityFrameworkCore;
using Radio_Room.Domain;


namespace Radio_Room.Data.dbContext
{
    public class Radio_RoomContext : DbContext
    {
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=DataBase/Dialogues.db");
        }

        public DbSet<Dialogue> dialogues { get; set; }
    }
}
