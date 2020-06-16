using System.Linq;
using ProjetoEscolar.Database;
using ProjetoEscolar.Database.Models;
using ProjetoEscolar.DTO;

namespace ProjetoEscolar.Repository
{
    public class RegisterRepository
    {
        public RegisterRepository(Context context){
            this.context = context;
        }
        private Context context;   
        public void register(RegisterDTO data){
            
            Usuario usuario = new Usuario{
                Tipo = 1,
                Email = data.Email,
                Nome = data.Nome,
                Senha = data.Senha
            };

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public bool EmailExiste(string email){

            Usuario usuario = context.Usuarios.Where
                                    (x => x.Email.Equals(email)).FirstOrDefault();

            if(usuario != null)
                return true;

            return false;
        }
    }
}