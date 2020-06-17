using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database.Entity
{
    public class ModuloEntity: IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.ToTable("modulo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("name");
            builder.Property(x => x.IdCurso).HasColumnName("id_curso");
            builder.HasOne<Curso>(x => x.Curs).WithMany(x=> x.Modulos).HasForeignKey(x => x.IdCurso);
        }
    
        
    }
}