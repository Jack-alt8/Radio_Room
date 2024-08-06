using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Radio_Room.UI;


namespace Radio_Room.UI.dbContext
{
    public class Radio_RoomDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var folder = Environment.SpecialFolder.Desktop;
            var path = Environment.GetFolderPath(folder);
            var DbPath = Path.Join(path, "Dialogues.db");
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }

        public DbSet<Dialogue> Dialogues { get; set; }
    }
}
