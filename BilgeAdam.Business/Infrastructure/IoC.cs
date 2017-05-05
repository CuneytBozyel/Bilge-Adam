using Autofac;
using BilgeAdam.Business.User;

namespace BilgeAdam.Business.Infrastructure
{
    public static class IoC
    {
        public static ContainerBuilder Builder;
        private static IContainer Container;

        static IoC()
        {
            if (Builder == null)
            {
                Builder = new ContainerBuilder();
               Builder.RegisterType<UserService>().As<IUserService>();
            }
        }

        public static IContainer CreateContainer()
        {
            Container = Builder.Build();
            return Container;
        }

        public static T Resolve<T>()
        {
            return Container.Resolve<T>();
        }
    }
}
