using ContactBookAPI_Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookAPI_Infrastructure.Repositories.Abstractions
{
    public interface IContactRepository : IRepositoryBase<Contact>
    {
    }
}
