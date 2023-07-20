using Microsoft.Extensions.DependencyInjection;

namespace Dev.ta.Application.Dto
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddDto(this IServiceCollection services)
        {
            return services;
        }
    }
}
