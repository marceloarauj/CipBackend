using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ProjetoEscolar.Validations
{
    public class EmailValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext){
            var email = (string)value;
            Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            
            if(!rgx.IsMatch(email)){
                return new ValidationResult("Email com formato inválido");
            }
            return ValidationResult.Success;
        }
    }
}