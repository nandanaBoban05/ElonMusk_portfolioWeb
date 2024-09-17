using ElonMusk_portfolioWeb.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElonMusk_portfolioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ProjectController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetProject()
        {

            return Ok(dbContext.Projects.ToList());
        }
    }
}
