using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstracts;
using DataAccess.Concretes;


namespace Business.DependencyResolves.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            //Activity
            builder.RegisterType<ActivityManager>().As<IActivityService>().SingleInstance();
            builder.RegisterType<ActivityDal>().As<IActivityDal>().SingleInstance();

            //Food
            builder.RegisterType<FoodManager>().As<IFoodService>().SingleInstance();
            builder.RegisterType<FoodDal>().As<IFoodDal>().SingleInstance();

            //Health Status
            builder.RegisterType<HealthManager>().As<IHealthService>().SingleInstance();
            builder.RegisterType<HealthStatusDal>().As<IHealthStatusDal>().SingleInstance();

            //Pet
            builder.RegisterType<PetManager>().As<IPetService>().SingleInstance();
            builder.RegisterType<PetDal>().As<IPetDal>().SingleInstance();

            //User
            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<UserDal>().As<IUserDal>().SingleInstance();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();
            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
               .EnableInterfaceInterceptors(new ProxyGenerationOptions()
               {
                   Selector = new AspectInterceptorSelector()
               }).SingleInstance();
        }
    }
}
