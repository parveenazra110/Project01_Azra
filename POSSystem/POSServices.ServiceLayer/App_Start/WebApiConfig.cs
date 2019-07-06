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
                name: "ProductApi",
                routeTemplate: "api/{Product}/{Action}/{id}",
                defaults: new { controller = "Product", action = "GetAllProducts", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "DefaultApi",
               routeTemplate: "api/{User}/{ValidateUser}/{emailid}/{password}",
               defaults: new { controller = "User", action = "ValidateUser", emailid = RouteParameter.Optional, password = RouteParameter.Optional }
           );
            
           
        }
    }
}
