using Microsoft.EntityFrameworkCore;
using ProjetoEscolar.Database.Entity;
using ProjetoEscolar.Database.Models;

namespace ProjetoEscolar.Database
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) :base(options)
        {
            
        } 
        
        public DbSet<Usuario> Usuarios {get;set;}
        protected override void OnModelCreating(ModelBuilder model){
            model.ApplyConfiguration(new UsuarioEntity());

            base.OnModelCreating(model);
        }
    }
}