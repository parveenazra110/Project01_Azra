using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace POSServices.ServiceLayer
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
              name: "UserApi",
              routeTemplate: "api/{Controller}/{Action}/{id}/{id1}",
              defaults: new { controller = "User", action = "ValidateUser", emailid = RouteParameter.Optional, password = RouteParameter.Optional }
          );
            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{Controller}/{Action}/{id}",
                defaults: new { controller = "Product", action = "GetAllProducts", id = RouteParameter.Optional }
            );
           
            
           
        }
    }
}
