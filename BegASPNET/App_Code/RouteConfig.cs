//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

///// <summary>
///// Summary description for RouteConfig
///// </summary>
//public class RouteConfig
//{
//    public RouteConfig()
//    {
//        //
//        // TODO: Add constructor logic here
//        //
//    }
//}
using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

public static class RouteConfig
{
    public static void RegisterRoutes(RouteCollection routes)
    {
        var settings = new FriendlyUrlSettings();
        settings.AutoRedirectMode = RedirectMode.Permanent;
        routes.EnableFriendlyUrls(settings);
    }
}