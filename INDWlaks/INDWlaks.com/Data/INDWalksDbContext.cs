using INDWlaks.com.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace INDWlaks.com.Data
{
    public class INDWalksDbContext: DbContext
    {
        public INDWalksDbContext (DbContextOptions<INDWalksDbContext> options) : base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walk { get; set; }

        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }
    }
}
