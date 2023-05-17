using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChLogicDempo.Controllers
{
    public class ControllerBase : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            ViewBag.ErrorMessage = "An error occurred: " + filterContext.Exception.Message;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult
            {
                ViewName = "~/Views/Shared/Error.cshtml"
            };

        }
    }
}