using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WindowsAuthenticationExample.Data
{
    public class GetUser
    {
        private readonly IHttpContextAccessor httpContextAccessor;
        public GetUser(IHttpContextAccessor _httpContextAccessor)
        {
            httpContextAccessor = _httpContextAccessor;
            //Parameters included on the class constructor are automatically dependency injected
            //https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-5.0
        }
        public async Task<string> GetUserName()
        {
            if (!string.IsNullOrEmpty(httpContextAccessor.HttpContext.User.Identity.Name))
            {
                return httpContextAccessor.HttpContext.User.Identity.Name;
            }
            return null;
        }
    }
}