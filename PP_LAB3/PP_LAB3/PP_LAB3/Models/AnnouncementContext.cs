using System.Data.Entity;
namespace PP_LAB3.Models
{
    public class AnnouncementContext: DbContext
    {
        public AnnouncementContext() : base("DbConnection") { }
        public DbSet<Announcement> Announ { get; set; }

    }
}
