using Microsoft.EntityFrameworkCore;

using aec_gama_api.Models;

public class DbContexto : DbContext
  {
    public DbContexto(DbContextOptions<DbContexto> options) : base (options) { }

    public DbSet<Candidato> Candidatos { get; set; }
    public DbSet<Profissao> Profissoes { get; set; }
  }