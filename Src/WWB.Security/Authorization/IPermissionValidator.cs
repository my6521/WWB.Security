using WWB.Security.Dto;

namespace WWB.Security.Authorization
{
    public interface IPermissionValidator
    {
        PermissionValidResult Valid(string permission);
    }
}