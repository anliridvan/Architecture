using Architecture.Model;
using DotNetCore.Objects;
using DotNetCore.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Architecture.Application
{
    public interface IUserService
    {
        Task<IResult<Guid>> AddAsync(UserModel model);

        Task<IResult> DeleteAsync(Guid id);

        Task<UserModel> GetAsync(Guid id);

        Task InactivateAsync(Guid id);

        Task<PagedList<UserModel>> ListAsync(PagedListParameters parameters);

        Task<IEnumerable<UserModel>> ListAsync();

        Task<IResult> UpdateAsync(UserModel model);
    }
}
