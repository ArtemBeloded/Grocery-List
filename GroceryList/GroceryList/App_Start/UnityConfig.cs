using GroceryList.BLL.Services;
using GroceryList.DAL.Repositories;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace GroceryList
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IProductService, ProductService>();
            container.RegisterType<HttpContextBase>(new InjectionFactory(_ =>
                new HttpContextWrapper(HttpContext.Current)));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}