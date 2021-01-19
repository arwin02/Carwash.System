using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Helpers
{
    public class LoggingAuthorizationHandler : AuthorizationHandler<MyRequirement>
    {
        ILogger _logger;

        public LoggingAuthorizationHandler(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger(this.GetType().FullName);
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, MyRequirement requirement)
        {
            _logger.LogInformation("Inside my handler");
            // Check if the requirement is fulfilled.
            return Task.CompletedTask;
        }
    }

    public class MyRequirement : IAuthorizationRequirement
    {
    }
}