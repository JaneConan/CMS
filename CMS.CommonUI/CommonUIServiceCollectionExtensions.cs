using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;

namespace CMS.CommonUI
{
    public static class CommonUIServiceCollectionExtensions
    {
        public static void AddCommonUI(this IServiceCollection services)
        {
            services.ConfigureOptions(typeof(CommonUIConfigureOptions));
        }
    }
}
