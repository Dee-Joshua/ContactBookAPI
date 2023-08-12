using ContactBookAPI_Infrastructure.Persistence;
using ContactBookAPI_Infrastructure.Repositories.Abstractions;
using ContactBookAPI_Infrastructure.Repositories.Implementations;

namespace ContactBookAPI_Infrastructure.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IUserRepository _userRepository;
        private IContactRepository _contactRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IUserRepository Users => _userRepository ??= new UserRepository(_context);

        public IContactRepository Contacts => _contactRepository ??= new ContactRepository(_context);

        public async Task SaveAync() => await _context.SaveChangesAsync();
    }
}
