using System.Data;
using System.Collections.Generic;
using Desafio3.Models;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Repositories
{
    public class UserRepository
    {
        List<User> user = new List<User>(){
            new User {Username = "fulano",Password = "123"},
            new User {Username = "ciclano", Password = "456"}
        };

        
        public User Get(string Username,string Password)
        {
            return user.Where(usuario => 
                usuario.Username.ToLower() == Username.ToLower() && usuario.Password.ToLower() == Password.ToLower())
                .FirstOrDefault(); 
        }

        public List<User> Set(string name,string senha)
        {
            user.Add(new User {Username = name,Password = senha});

            return user;
        }


    }
}