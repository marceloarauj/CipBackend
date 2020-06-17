namespace ProjetoEscolar.Database.Models
{
    public class CadastroCurso
    {
        public int IdUsuario{get;set;}
        public int IdCurso{get;set;}
        public Usuario Usu{get;set;}
        public Curso Curs{get;set;}
    }
}