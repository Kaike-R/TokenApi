using System;
using System.Threading.Tasks;

namespace Desafio3.Services
{
    public class AccountService
    {
        public async Task<string> GetFinancial()
        {
            await Task.Delay(1000);
            Random rnd = new Random();
            int x = rnd.Next(1,5);
            if(x == 2){
                return "Sucess";
            }
            else
            {
                return "Fail";
            }
        }
    }
}