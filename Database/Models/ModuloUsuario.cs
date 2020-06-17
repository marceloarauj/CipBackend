using System;

namespace ProjetoEscolar.Database.Models
{
    public class ModuloUsuario
    {
        public int IdModulo{get;set;}
        public int IdUsuario{get;set;}
        public Modulo Mod{get;set;}
        public Usuario Usu{get;set;}
        public bool Pago{get;set;}
        public DateTime DataPagamento{get;set;}
        public string FormaPagamento{get;set;}   
    }
}