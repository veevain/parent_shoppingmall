using Microsoft.Extensions.DependencyInjection;

namespace Parent.AgileFramework.WechatPayCore
{
    public static class WechatRegisterExtend
    {
        public static void AddWechatPay(this IServiceCollection services)
        {
            services.AddTransient<IWxPayConfig, WxPayConfig>();
            services.AddTransient<PayHelper>();
            services.AddTransient<WxPayApi>();
            services.AddTransient<WxPayHttpService>();


        }
    }
}
