using Microsoft.AspNetCore.Mvc;

namespace WWB.Security.Authorization
{
    public class PermissionAuthorizeAttribute : TypeFilterAttribute
    {
        public PermissionAuthorizeAttribute(string permission) : base(typeof(RequirementPermissionFilter))
        {
            Arguments = new object[] { permission };
        }
    }
}