using Angular.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular.API.Data
{
    public interface IAuthRepository
    {
        Task<Users> Register(Users user, string password);
        Task<Users> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}
