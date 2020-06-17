using System.Collections.Generic;

namespace ProjetoEscolar.Database.Models
{
    public class Modulo
    {
        public int Id{get;set;}
        public int IdCurso{get;set;}
        public ICollection<ModuloUsuario> ModuloUsu{get;set;}
        public string Nome{get;set;}
        public Curso Curs {get;set;}
        public ICollection<Arquivo> Arquivos {get;set;}
    }
}