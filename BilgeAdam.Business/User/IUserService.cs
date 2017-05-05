using BilgeAdam.Business.BaseResult;
using BilgeAdam.Data.Entitiy;
using System.Collections.Generic;

namespace BilgeAdam.Business.User
{
    public interface IUserService
    {
        ServiceResult<List<Users>> GetAllUsers();
    }
}
