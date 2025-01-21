using Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Infra;

public class ApiFinanceiroContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<TipoMovi> TipoMovimentacao { get; set; }
    public DbSet<Movimentacao> Movimentacao { get; set; }
    public DbSet<CategoriaMovi> CategoriaMovis { get; set; }
    public DbSet<Login> Logins { get; set; }

    public ApiFinanceiroContext(DbContextOptions<ApiFinanceiroContext> options)
           : base(options) { }

}
