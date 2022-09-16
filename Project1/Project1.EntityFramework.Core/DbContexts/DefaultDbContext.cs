using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Project1.EntityFramework.Core
{
    [AppDbContext("NFCOA",$"{DbProvider.Oracle}@11" )]
    public class DefaultDbContext : AppDbContext<DefaultDbContext>
    {
        public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
        {
        }
    }
}