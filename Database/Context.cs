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
        public DbSet<CadastroCurso> CadastroCursos{get;set;}
        public DbSet<Curso> Cursos{get;set;}
        protected override void OnModelCreating(ModelBuilder model){
            model.ApplyConfiguration(new UsuarioEntity());
            model.ApplyConfiguration(new CursoEntity());
            model.ApplyConfiguration(new CadastroCursoEntity());
            model.ApplyConfiguration(new ModuloEntity());

            base.OnModelCreating(model);
        }
    }
}