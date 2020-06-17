using System.Collections.Generic;

namespace ProjetoEscolar.Database.Models
{
    public class Curso
    {
        public int Id{get;set;}
        public string Nome {get;set;}
        public ICollection<CadastroCurso> Cadastros{get;set;}
        public ICollection<Modulo> Modulos{get;set;}
    }
}