using Microsoft.EntityFrameworkCore;
using UploadingImagesToDatabaseWithApi.Shared;

namespace UploadingImagesToDatabaseWithApi.Server;

public class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }

    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Image>? Images { get; set; }
    public virtual DbSet<QrBuildingProblem>? BuildingProblems { get; set; }
}