using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Angular.API.Data;
using Angular.API.Dtos;
using Angular.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Angular.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repo;

        public AuthController(IAuthRepository repo)
            => _repo = repo;
        

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserForRegisterDto userForRegisterDto)
        {
            userForRegisterDto.Username = userForRegisterDto.Username.ToLower();

            if (await _repo.UserExists(userForRegisterDto.Username))
                return BadRequest("Username already exists");

            var userToCreate = new Users
            {
                Username = userForRegisterDto.Username
            };

            var createdUser = await _repo.Register(userToCreate, userForRegisterDto.Password);

            return Ok(User);

        }
    }
}