using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Infrastructure
{
    public interface IContactService
    {
        ContactDTO GetContactById(int id);
        List<ContactDTO> GetAll();
        void Add(ContactDTO contact);
        void Delete(int id);
    }
}
