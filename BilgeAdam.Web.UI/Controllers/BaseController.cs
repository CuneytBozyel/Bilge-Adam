using BilgeAdam.Business.Infrastructure;
using BilgeAdam.Business.User;
using System.Web.Mvc;

namespace BilgeAdam.Web.UI.Controllers
{
    public class BaseController : Controller
    {
        public IUserService UserService => IoC.Resolve<IUserService>();
    }
}