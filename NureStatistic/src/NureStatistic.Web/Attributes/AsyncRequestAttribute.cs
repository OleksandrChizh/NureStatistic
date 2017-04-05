using Microsoft.AspNetCore.Mvc.Filters;
using System;
using NureStatistic.Web.Utils;
using Microsoft.AspNetCore.Mvc;

namespace NureStatistic.Web.Attributes
{
    public class AsyncRequestAttribute : Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var request = context.HttpContext.Request;

            if (!request.IsAjaxRequest())
            {
                context.HttpContext.Response.Cookies.Append("url-before-page-updating", context.HttpContext.Request.Path);
                context.Result = new RedirectToActionResult("Index", "Home", null);
            }
        }
    }
}
