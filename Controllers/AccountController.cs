using System.Threading.Tasks;
using Desafio3.Models;
using Desafio3.Repositories;
using Desafio3.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Desafio3.Controllers
{

    [Route("v1/account")]
    public class AccountController:ControllerBase
    {
        [HttpPost]
        [Route("createaccount")]
        [Authorize()]
        public async Task<ActionResult<dynamic>> CreateAccount([FromBody] User model)
        {
            
            var conta = new UserRepository().Set(model.Username, model.Password);
            return "Criação efetuada com sucesso";
        }

        [HttpPost]
        [Route("getFinancial")]
        [Authorize]
        public async Task<ActionResult<dynamic>> GetFinancial()
        {
            
            var fiancial = await new AccountService().GetFinancial();
            return fiancial;
        }
    }
}