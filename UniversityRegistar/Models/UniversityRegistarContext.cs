using Microsoft.EntityFrameworkCore;

namespace University.Models
{
  public class UniversityRegistarContext : DbContext
  {

    public UniversityRegistarContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}