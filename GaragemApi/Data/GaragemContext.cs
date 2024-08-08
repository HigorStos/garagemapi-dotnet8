using Microsoft.EntityFrameworkCore;

namespace GaragemApi.Data;

public class GaragemContext : DbContext
{
    public GaragemContext(DbContextOptions<GaragemContext> options) : base(options) { }

    public DbSet<Veiculo> Veiculos { get; set; }
}
