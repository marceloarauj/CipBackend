using ProjetoEscolar.Validations;

namespace ProjetoEscolar.DTO
{
    public class RegisterDTO
    {
        [EmailValidation]
        public string Email {get;set;} 
        public string Senha {get;set;}
        public string Nome {get;set;}
        
    }
}