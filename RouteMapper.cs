using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using DotNetNuke.Web.Api;

namespace AAModules.HTCAPI.Controllers
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {

            mapRouteManager.MapHttpRoute(
            moduleFolderName: "AAModules/HTCAPI",
            routeName: "GetByParentId",
            url: "{controller}/{action}/{id}",     
            namespaces: new[] { "AAModules.HTCAPI.Controllers" });
            //http://dnndev.me/API/AAModules/HTCAPI/ItemMedia/GetByParentId/1

            mapRouteManager.MapHttpRoute(
                moduleFolderName: "AAModules/HTCAPI",
                routeName: "default",
                url: "{controller}/{id}",
                defaults: new { id = RouteParameter.Optional },
                namespaces: new[] { "AAModules.HTCAPI.Controllers" });
            //http://dnndev.me/API/AAModules/HTCAPI/Auction
        }
    }
}