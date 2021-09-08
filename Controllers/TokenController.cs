
using System.Threading.Tasks;
using Desafio3.Models;
using Desafio3.Repositories;
using Desafio3.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desafio3.Controllers
{
    [Route("v1/token")]
    public class TokenController:ControllerBase
    {
        [HttpPost]
        [Route("getoken")]
        [AllowAnonymous]      
        public async Task<ActionResult<dynamic>> Authentication([FromBody]User model)
        {
            
            
            var user = new UserRepository().Get(model.Username, model.Password);
            

            if(user == null){
                return NotFound(new { message = "usuario ou senha errada"});
            }
            
            var token = new TokenService().GenerateToken(user);
            user.Password = "";
            return new 
            {
                user = user,
                token = token
            };

        }

    }
}