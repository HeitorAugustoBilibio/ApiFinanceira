using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra;

public class ApiFinanceiroContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<MovementType> MovementTypes { get; set; }
    public DbSet<Movement> Movements { get; set; }
    public DbSet<CategoryMovement> CategoryMovements { get; set; }
    public DbSet<Login> Logins { get; set; }

    public ApiFinanceiroContext(DbContextOptions<ApiFinanceiroContext> options)
           : base(options) { }

}
