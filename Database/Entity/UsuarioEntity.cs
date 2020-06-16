using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database.Entity
{
    public class UsuarioEntity : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            builder.Property(x => x.Email).HasColumnName("email");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Senha).HasColumnName("senha");
            builder.Property(x => x.Tipo).HasColumnName("tipo");
        }
    }
}