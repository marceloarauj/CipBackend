using Microsoft.AspNetCore.Mvc;
using ProjetoEscolar.Configurations;
using ProjetoEscolar.DTO;
using ProjetoEscolar.Services;

namespace ProjetoEscolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegisterController:ControllerBase
    {
        public RegisterController(RegisterService registerService){
            this.registerService =registerService;
        }
        private RegisterService registerService;
        [HttpPost]
        public ActionResult register([FromBody] RegisterDTO data){
            data.Senha = EncryptConfiguration.EncryptPassword(data.Senha);

            bool registered = registerService.register(data);
            
            if(!registered)
                return BadRequest("Já existe uma conta associada à este email");

            return Ok("Usuário cadastrado com sucesso");
        }
    }
}