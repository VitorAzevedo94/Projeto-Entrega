using Controle.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Controle.Data

{
    public class Cad : DbContext
    {
        public BancoDbContext(DbContextOptions<BancoDbContext> options)
        : base(options)
        {
        }
        public DbSet<CadastroModel> Cadastro { get; set; }
    }
}
