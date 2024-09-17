using ElonMusk_portfolioWeb.Data;
using ElonMusk_portfolioWeb.Models.Enitites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElonMusk_portfolioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public AboutController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAbout()
        {
           
            return Ok(dbContext.Details.ToList());
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateDetail(Detail detail)
        {
            var aboutDetail=dbContext.Details.FirstOrDefault();
            if (aboutDetail == null)
            {
                return NotFound();
            }
            aboutDetail.Occupation = detail.Occupation;
            aboutDetail.Email = detail.Email;
            aboutDetail.Phone = detail.Phone;

            dbContext.SaveChanges();
            return Ok(aboutDetail);


        }
    }
}