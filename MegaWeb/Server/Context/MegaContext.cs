using MegaWeb.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace MegaWeb.Server.Context
{
    public class MegaContext : DbContext
    {
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Funcao> Funcao { get; set; }
        public DbSet<SituacaoFuncionario> SituacaoFuncionario { get; set; }
        public DbSet<Ponto> Ponto { get; set; }
        public DbSet<LogPonto> Log { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<StatusLancamentoPonto> StatusLancamentoPonto { get; set; }

        public MegaContext(DbContextOptions<MegaContext> options) : base(options)
        {
        }

        public MegaContext()
        {
        }
    }
}