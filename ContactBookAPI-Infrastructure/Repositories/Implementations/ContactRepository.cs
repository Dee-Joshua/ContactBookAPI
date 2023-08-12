using ContactBookAPI_Domain.Models;
using ContactBookAPI_Infrastructure.Persistence;
using ContactBookAPI_Infrastructure.Repositories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI_Infrastructure.Repositories.Implementations
{
    public class ContactRepository : RepositoryBase<Contact>, IContactRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
