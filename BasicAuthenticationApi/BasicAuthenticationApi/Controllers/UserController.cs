using BasicAuthenticationApi.DTOs;
using BasicAuthenticationApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BasicAuthenticationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        public readonly UserContext _userContext;

        public UserController(UserContext userContext)
        {
            _userContext = userContext;
        }
        [HttpPost]
        [Route("register")]
        public IActionResult Register(UserDTO userDTO)
        {
            var user = new User
            {
                Firstname = userDTO.Firstname,
                Lastname = userDTO.Lastname,
                Email = userDTO.Email,
                Password = userDTO.Password
            };
            var existingUser =  _userContext.Users.FirstOrDefault(u => u.Email == user.Email);
            //foreach (var existingUser in await userContext.Users.ToListAsync())
            //{
            //    if (existingUser.Email == user.Email)
            //    {
            //        isExists = true;
            //        return BadRequest("Email already exists.");
            //    }
            //}
            if (existingUser != null)
            {
                return BadRequest("Email already exists.");
            }
            
                 _userContext.Users.Add(user);
                 _userContext.SaveChanges();
                return Ok(user);
            
           

        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginDTO logindto)
        {
            var user = _userContext.Users.FirstOrDefault(u => u.Email == logindto.Email && u.Password == logindto.Password&&u.IsActive==true);
            if (user != null)
            {
                return Ok("Login successful.");
            }
            else
            {
                return Unauthorized("Invalid email or password.");
            }
        }
    }
}
