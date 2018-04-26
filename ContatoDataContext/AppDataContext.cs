using Contatos.Models;
using Microsoft.EntityFrameworkCore;

namespace Contatos.ContatoDataContext
{
    public class AppDataContext : DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }
    }
}