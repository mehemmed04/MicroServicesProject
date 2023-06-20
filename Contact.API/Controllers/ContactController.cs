using Contact.API.Infrastructure;
using Contact.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet("{id}")]
        public ContactDTO Get(int id)
        {
            return _contactService.GetContactById(id);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _contactService.Delete(id);
            return NoContent();
        }

        [HttpGet("")]
        public List<ContactDTO> GetAll()
        {
            return _contactService.GetAll();
        }

        [HttpPost]
        public ContactDTO Add(ContactDTO contact)
        {
            _contactService.Add(contact);
            return contact;
        }
    }
}
