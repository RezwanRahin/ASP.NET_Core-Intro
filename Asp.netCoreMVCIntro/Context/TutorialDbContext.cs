using Asp.netCoreMVCIntro.Models;
using Microsoft.EntityFrameworkCore;

namespace Asp.netCoreMVCIntro.Context;

public class TutorialDbContext : DbContext
{
    public DbSet<Tutorial> Tutorials { get; set; }
}
