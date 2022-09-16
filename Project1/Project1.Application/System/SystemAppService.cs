namespace Project1.Application
{
    /// <summary>
    /// 系统服务接口
    /// </summary>
    [Authorize]
    public class SystemAppService : IDynamicApiController
    {
        private readonly ISystemService _systemService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SystemAppService(ISystemService systemService,IHttpContextAccessor httpContextAccessor)
        {
            _systemService = systemService;
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// 获取系统描述
        /// </summary>
        /// <returns></returns>
        
        public string GetDescription()
        {
            return _systemService.GetDescription();
        }

        [HttpPost]
        public void SendData(ReturnDto dto)
        {
            
        }

        [HttpPost]
        [AllowAnonymous]
        public string Login([FromForm] string user, [FromForm] string password)
        {
            var accessToken = JWTEncryption.Encrypt(new Dictionary<string, object>()
            {
                { "UserId", user },  // 存储Id
                { "Account",new[]{"Admin","User"} }, // 存储用户名
                
            });

            var refreshToken = JWTEncryption.GenerateRefreshToken(accessToken, 43200); // 第二个参数是刷新 token 的有效期（分钟），默认三十天
// 设置响应报文头
            _httpContextAccessor.HttpContext.Response.Headers["access-token"] = accessToken;
            _httpContextAccessor.HttpContext.Response.Headers["x-access-token"] = refreshToken;

            return accessToken;
        }

    }
}