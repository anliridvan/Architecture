using Architecture.Domain;
using Architecture.Model;
using DotNetCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Architecture.Database
{
    public sealed class UserRepository : EFRepository<User>, IUserRepository
    {
        public UserRepository(Context context) : base(context) { }

        public Task<Guid> GetAuthIdByUserIdAsync(Guid id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.AuthId).SingleOrDefaultAsync();
        }

        public Task<UserModel> GetByIdAsync(Guid id)
        {
            return Queryable.Where(UserExpression.Id(id)).Select(UserExpression.Model).SingleOrDefaultAsync();
        }

        public Task UpdateStatusAsync(User user)
        {
            return UpdatePartialAsync(user.Id, new { user.Status });
        }
    }
}
