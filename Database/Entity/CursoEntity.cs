using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database.Entity
{
    public class CursoEntity: IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder.ToTable("curso");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).HasColumnName("nome");
        }
          
    }
}