using Microsoft.EntityFrameworkCore;

namespace CombatReports.Data.Models
{
    public partial class MilitaryOrdersContext : DbContext
    {
        public MilitaryOrdersContext()
        {
        }

        public MilitaryOrdersContext(DbContextOptions<MilitaryOrdersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Hash> Hashes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Form> Forms { get; set; }
        public virtual DbSet<FormType> FormTypes { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserAccess> UserAccesses { get; set; }
    }
}