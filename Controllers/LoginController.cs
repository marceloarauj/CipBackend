using Microsoft.AspNetCore.Mvc;
using ProjetoEscolar.DTO;

namespace ProjetoEscolar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController:ControllerBase
    {
        [HttpPost]
        public ActionResult<string> login([FromBody] LoginDTO data){

            
            return Ok("okay");
        }

    }
}