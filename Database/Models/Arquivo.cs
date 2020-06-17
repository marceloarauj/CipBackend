namespace ProjetoEscolar.Database.Models
{
    public class Arquivo
    {
        public int Id{get;set;}
        public int IdModulo{get;set;}
        public Modulo Mod{get;set;}
        public string Path{get;set;}
        public string Extensao{get;set;}
        public string Nome{get;set;}
    }
}