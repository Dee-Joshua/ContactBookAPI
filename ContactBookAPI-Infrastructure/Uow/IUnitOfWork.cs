using ContactBookAPI_Infrastructure.Repositories.Abstractions;

namespace ContactBookAPI_Infrastructure.Uow
{
    public interface IUnitOfWork
    {
        IUserRepository Users { get; }
        IContactRepository Contacts { get; }
        Task SaveAync();
    }
}