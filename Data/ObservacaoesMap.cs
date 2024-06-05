using Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data
{
    public class ObservacaoesMap : IEntityTypeConfiguration<ObservacoesModel>
    {
        public void Configure(EntityTypeBuilder<ObservacoesModel> builder)
        {
            builder.HasKey(x => x.ObservacoesId);
            builder.Property(x => x.ObservacoesDescricao).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObservacoesLocal).IsRequired().HasMaxLength(255);
            builder.Property(x => x.ObservacoesData).IsRequired().HasMaxLength(255);
            builder.Property(x => x.UsuarioId).IsRequired().HasMaxLength(255);
            builder.Property(x => x.PessoaId).IsRequired().HasMaxLength(255);

        }
    }
}
