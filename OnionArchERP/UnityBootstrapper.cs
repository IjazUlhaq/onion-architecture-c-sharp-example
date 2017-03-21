using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Mvc;
using System;
using System.Collections.Generic;
using OnionArch.Infrastructure.Repository;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnionArchERP.Infrastructure.Interfaces;

namespace OnionArchERP
{
    public class UnityBootstrapper
    {
        public static IUnityContainer Initialise()
        {
            var container = BuildUnityContainer();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            return container;
        }

        public static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return container;
        }

        public static void RegisterTypes(IUnityContainer container)
        {

        }
    }
}