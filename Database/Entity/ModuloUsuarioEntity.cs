using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database.Entity
{
    public class ModuloUsuarioEntity: IEntityTypeConfiguration<ModuloUsuario>
    {
        public void Configure(EntityTypeBuilder<ModuloUsuario> builder)
        {
            builder.ToTable("modulo_usuario");
            builder.HasNoKey();
            builder.Property(x => x.Pago).HasColumnName("pago");
            builder.Property(x => x.DataPagamento).HasColumnName("data_pagamento");
            builder.Property(x => x.FormaPagamento).HasColumnName("forma_pagamento");
            builder.HasOne<Modulo>(x => x.Mod).WithMany(x => x.ModuloUsu).HasForeignKey(x => x.IdModulo);
            builder.HasOne<Usuario>(x => x.Usu).WithMany(x => x.ModuloUsu).HasForeignKey(x => x.IdUsuario);
        }
    
        
    }
}