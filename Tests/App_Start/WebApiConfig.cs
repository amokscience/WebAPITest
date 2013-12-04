using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPITest.Core;
using WebAPITest.Repository;

namespace Tests
{
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.MapHttpAttributeRoutes();

			config.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

			// Simple Injector Dependency Injection Framework
			var container = new SimpleInjector.Container();
			var services = GlobalConfiguration.Configuration.Services;
			var controllerTypes = services.GetHttpControllerTypeResolver().GetControllerTypes(services.GetAssembliesResolver());

			// register Web API controllers (important! http://bit.ly/1aMbBW0)
			foreach (var controllerType in controllerTypes)
			{
				container.Register(controllerType);
			}

			// Register your types here
			container.Register<IProductRepository, ProductRepository>();

			container.Verify();
			System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);
		}
	}
}