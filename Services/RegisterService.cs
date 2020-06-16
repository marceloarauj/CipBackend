using ProjetoEscolar.DTO;
using ProjetoEscolar.Repository;

namespace ProjetoEscolar.Services
{
    public class RegisterService
    {
        public RegisterService(RegisterRepository registerRepository){
            this.registerRepository = registerRepository;
        }
        private RegisterRepository registerRepository;
        public bool register(RegisterDTO data){

            bool emailExist = registerRepository.EmailExiste(data.Email);

            if(emailExist){
                return false;
            }
            
            registerRepository.register(data);
            return true;
        }
    }
}