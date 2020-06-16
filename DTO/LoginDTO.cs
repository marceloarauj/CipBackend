using ProjetoEscolar.Validations;

namespace ProjetoEscolar.DTO
{
    public class LoginDTO
    {
        [EmailValidation]
        public string Email{get;set;}
        public string Senha{get;set;}
    }
}