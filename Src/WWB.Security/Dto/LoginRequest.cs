using System.ComponentModel.DataAnnotations;

namespace WWB.Security.Dto
{
    /// <summary>
    /// 登录请求
    /// </summary>
    public class LoginRequest
    {
        [Required(ErrorMessage = "登录账号不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "登录密码不能为空")]
        public string Password { get; set; }
    }
}