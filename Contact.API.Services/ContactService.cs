using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService:IContactService
    {
        public static List<ContactDTO> AllContacts { get; set; }
        = new List<ContactDTO>
        {
            new ContactDTO
            {
                Id=new Random().Next(1,100000),
                 FirstName="Ali",
                  LastName="Aliyev"
            },
            new ContactDTO
            {
                Id=new Random().Next(1,100000),
                FirstName="Aysel",
                LastName="Aliyeva"
            },
            new ContactDTO
            {
                Id=new Random().Next(1,100000),
                FirstName="Tural",
                LastName="Mammadov"
            }
        };

        public void Add(ContactDTO contact)
        {
            contact.Id = new Random().Next(1, 100000);
            AllContacts.Add(contact);
        }

        public void Delete(int id)
        {
            var item = AllContacts.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                AllContacts.Remove(item);
            }
        }

        public List<ContactDTO> GetAll()
        {
            return AllContacts;
        }

        public ContactDTO GetContactById(int id)
        {
            return AllContacts.FirstOrDefault(c => c.Id == id);
        }
    }
}
