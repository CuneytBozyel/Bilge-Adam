using BilgeAdam.Data.Entitiy;
using BilgeAdam.Data.EntityPattern;
using System.Collections.Generic;
using System.Linq;

namespace BilgeAdam.Business.User
{
    public class UserService : BaseService<tts_user>, IUserService
    {
        public List<tts_user> GetAllUsers()
        {
            List<tts_user> result = new List<tts_user>();

            try
            {
                var users = Repo.List().ToList();
                result = users;

            }
            catch (System.Exception)
            {
                throw;
            }

            return result;
        }

    }
}
