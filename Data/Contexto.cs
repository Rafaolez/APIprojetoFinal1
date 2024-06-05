using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

       // public DbSet<UsersModel> User { get; set; }
        public DbSet<UsuarioModel> Usuario { get; set; }
        public DbSet<ObservacoesModel> Observacoes { get; set; }
        public DbSet<PessoaModel> Pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new UsersMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ObservacaoesMap());
            base.OnModelCreating(modelBuilder);
        }

    }
}
