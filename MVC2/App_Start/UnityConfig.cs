using AutoMapper;
using BusinessLogic;
using DAL.Interfaces;
using DALef.Concrete;
using MoviesMVC.App.Profiles;
using System;
using System.Web.Mvc;
using Unity;
using Unity.AspNet.Mvc;

namespace MVC2
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        public static void RegisterUnity()
        {
            var container = new UnityContainer();
            MapperConfiguration config = new MapperConfiguration(
                cfg =>
                {
                    cfg.AddMaps(typeof(BasketDalEf).Assembly, typeof(BasketProfile).Assembly);
                });

            container.RegisterInstance<IMapper>(config.CreateMapper());
            container.RegisterType<IBasketDal, BasketDalEf>()
                     .RegisterType<IBooksDal, BookDalEf>()
                     .RegisterType<ICategoriesDal,CategoriesDalEf>()
                    // .RegisterType<IUserDal, UserDalEf>()
                     .RegisterType<ICustomer, Customer>()
                     .RegisterType<IAuthManager, AuthManager>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}