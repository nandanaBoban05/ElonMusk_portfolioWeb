using ElonMusk_portfolioWeb.Data;
using ElonMusk_portfolioWeb.Models.Enitites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElonMusk_portfolioWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public ContactController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetContact()
        {
            return Ok(dbContext.Contacts.ToList());
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            var contactentity = new Contact()
                {
                Name = contact.Name,
                Email = contact.Email,
                Subject = contact.Subject,
                Message = contact.Message,
            };


            dbContext.Contacts.Add(contactentity);
            dbContext.SaveChanges();

            return Ok(contactentity);

        }
    }
}
