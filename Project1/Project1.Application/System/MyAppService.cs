using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Project1.Application;

/// <summary>
/// 自定義控制器
/// </summary>
public class MyAppService:IDynamicApiController
{
    
    /// <summary>
    /// 取得我的DESC
    /// </summary>
    /// <returns></returns>
    public string GetMyDesc()
    {
        
        return "hello world";
    }
}