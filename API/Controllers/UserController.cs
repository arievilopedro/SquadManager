using Commom;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Autentica o usuário
        /// </summary>
        /// <param name="user">Username e Senha do usuário</param>
        /// <returns>OK se estiver logado</returns>
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            return Ok(new {response = "Está Logado!"});
        }
    }
}
