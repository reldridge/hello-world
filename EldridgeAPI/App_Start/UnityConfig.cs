using EldridgeCore.BO;
using EldridgeDomain.Interfaces.BO;
using System.Web.Http;
using Unity;
using Unity.WebApi;

namespace EldridgeAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IHelloWorldBO, HelloWorldBO>();
            
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}