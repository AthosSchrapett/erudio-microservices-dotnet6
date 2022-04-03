using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.IdentityServer.Model.Context
{
    public class PostgresContext : IdentityDbContext<ApplicationUser>
    {
		public PostgresContext(DbContextOptions<PostgresContext> options) : base(options) { }
	}
}
