using Microsoft.EntityFrameworkCore;
using RecordKeeper.Data;

namespace RecordKeeper.Data
{
    public class RecordKeeperDataContext : DbContext
    {
        public RecordKeeperDataContext(DbContextOptions<RecordKeeperDataContext> options) : base(options) { }

        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantSecurityInfo> TenantSecurityInfos { get; set; }
        public DbSet<TenantStayInfo> TenantStayInfos { get; set; }

    }
}
