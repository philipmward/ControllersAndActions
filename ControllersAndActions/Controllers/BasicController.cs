﻿using System;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllersAndActions.Controllers
{
    public class BasicController : IController
    {
        public void Execute(RequestContext requestContext)
        {
            var controller = (string)requestContext.RouteData.Values["controller"];
            var action = (string)requestContext.RouteData.Values["action"];

            if (action.ToLower() == "redirect")
            {
                requestContext.HttpContext.Response.Redirect("/Derived/Index");
            }
            else
            {
                requestContext.HttpContext.Response.Write(string.Format("Controller: {0}, Action: {1}", controller,
                    action));
            }
        }
    }
}