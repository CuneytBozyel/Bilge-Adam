using Autofac.Integration.Mvc;
using BilgeAdam.Business.Infrastructure;
using System.Web.Mvc;

namespace BilgeAdam.Web.UI.App_Start
{
    public class AutofacConfig
    {

        public static void ConfigureContainer()
        {
            var builder = IoC.Builder;
            DependencyResolver.SetResolver(new AutofacDependencyResolver(IoC.CreateContainer()));
        }

    }
}