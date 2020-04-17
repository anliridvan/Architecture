using Architecture.Domain;
using Architecture.Model;
using DotNetCore.Repositories;
using System;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public interface IUserRepository : IRepository<User>
    {
        Task<Guid> GetAuthIdByUserIdAsync(Guid id);

        Task<UserModel> GetByIdAsync(Guid id);

        Task UpdateStatusAsync(User user);
    }
}
