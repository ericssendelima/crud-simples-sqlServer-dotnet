using Microsoft.EntityFrameworkCore;
using PrimeiraApi.Entities;

namespace PrimeiraApi.Context
{
  public class AgendaContext(DbContextOptions<AgendaContext> options) : DbContext(options)
  {
    public DbSet<Contato> Contatos { get; set; }
  }
}