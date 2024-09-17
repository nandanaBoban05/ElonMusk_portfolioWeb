using ElonMusk_portfolioWeb.Data;
using ElonMusk_portfolioWeb.Models.Enitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElonMusk_portfolioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public LoginController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpPost]
        [Route("Login")]

        public IActionResult LogIn(Login login)
        {
            string adminName = "Admin";
            string adminPassword = "Adminpass";
            if(login.Username==adminName && login.Password == adminPassword)
            {
                var response = new
                {
                    Message = "Login successful",
                    User = "Admin"
                };
                return Ok(response);
            }
            return Unauthorized(" Invalid password and username.Only admin can Login");
        }
    }
}
