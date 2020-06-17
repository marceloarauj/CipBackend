using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database.Entity
{
    public class CadastroCursoEntity: IEntityTypeConfiguration<CadastroCurso>
    {
        public void Configure(EntityTypeBuilder<CadastroCurso> builder)
        {
            builder.ToTable("cadastro_curso");
            builder.HasKey(x => x.IdCurso);
            builder.HasKey(x => x.IdUsuario);

            builder.Property(x => x.IdCurso).HasColumnName("id_curso");
            builder.Property(x => x.IdUsuario).HasColumnName("id_usuario");
            
            builder.HasOne<Curso>(x => x.Curs).WithMany(x => x.Cadastros).HasForeignKey(fk => fk.IdCurso);
            builder.HasOne<Usuario>(x => x.Usu).WithMany(x => x.Cadastros).HasForeignKey(fk => fk.IdUsuario);
        }
        
    }
}