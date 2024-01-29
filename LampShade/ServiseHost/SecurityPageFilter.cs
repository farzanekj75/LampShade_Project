﻿using _0_Framework.Application;
using _0_Framework.Infrastructure;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Linq;
using System.Reflection;

namespace ServiseHost
{
    public class SecurityPageFilter : IPageFilter
    {
        private readonly IAuthHelper _authHelper;
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
          
        }

        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            var handlerPermission =
                 (NeedsPermissionAttribute)context.HandlerMethod.MethodInfo.GetCustomAttribute(
                     typeof(NeedsPermissionAttribute));

            if(handlerPermission == null)
                return;

            var accountPermission = _authHelper.GetPermissions();

            if (accountPermission.All(x => x != handlerPermission.Permission))
                context.HttpContext.Response.Redirect("/Login");
        }

        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
            
        }
    }
}
