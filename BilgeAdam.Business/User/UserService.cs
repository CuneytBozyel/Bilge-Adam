using BilgeAdam.Business.BaseResult;
using BilgeAdam.Data.Entitiy;
using BilgeAdam.Data.EntityPattern;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.Business.User
{
    public class UserService : BaseService<Users>, IUserService
    {
        public ServiceResult<List<Users>> GetAllUsers()
        {
            ServiceResult<List<Users>> result = new ServiceResult<List<Users>>();

            try
            {
                result.Result = Repo.List().ToList();
            }
            catch (System.Exception)
            {
                throw;
            }

            return result;
        }

    }
}
