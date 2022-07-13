using Microsoft.EntityFrameworkCore;

namespace NamEcommerce.Web.Data
{
    public sealed class NamEcommerceDbContext : DbContext
    {
        public NamEcommerceDbContext(DbContextOptions<NamEcommerceDbContext> opt) : base(opt)
        {
        }
    }
}
