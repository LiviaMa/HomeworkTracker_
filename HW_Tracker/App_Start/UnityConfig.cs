using HomeworkTracker.Models;
using HomeworkTracker.Repository;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace HomeworkTracker
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IRepository<Student>, InMemoryStudentRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IRepository<User>, InMemoryUserRepository>(new ContainerControlledLifetimeManager());
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}