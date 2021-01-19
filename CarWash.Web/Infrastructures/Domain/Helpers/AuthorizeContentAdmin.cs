using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Helpers
{
    public class AuthorizeContentAdminRequirementHandler : AuthorizationHandler<AuthorizeContentAdminRequirement>
    {
        public AuthorizeContentAdminRequirementHandler() { }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizeContentAdminRequirement requirement)
        {
            if (!WebUser.IsInRole(Infrastructures.Domain.Enums.Role.ContentAdmin) && !WebUser.IsInRole(Infrastructures.Domain.Enums.Role.Admin))
            {
                context.Fail();

                return Task.CompletedTask;
            }
            context.Succeed(requirement);
            return Task.CompletedTask;

   
        }
    }

    public class AuthorizeContentAdminRequirement : IAuthorizationRequirement
    {
    }
}