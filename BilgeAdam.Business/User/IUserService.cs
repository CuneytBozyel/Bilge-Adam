using BilgeAdam.Data.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.User
{
    public interface IUserService
    {
        List<tts_user> GetAllUsers();
    }
}
