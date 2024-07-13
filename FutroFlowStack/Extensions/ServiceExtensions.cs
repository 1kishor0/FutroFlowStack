using AutoMapper;
using FutroFlowStackBLL.MappingProfile;
using FutroFlowStackBLL.Service;
using FutroFlowStackBLL.ServiceInterface;
using FutroFlowStackDAL.Repository;
using FutroFlowStackDAL.RepositoryInterface;

namespace FutroFlowStackAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services, string corsPolicy)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(corsPolicy,
                    builder =>
                    {
                        builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                    });
            });
        }



        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {

            services.AddScoped<IDashboardRepository, DashboardRepository>();
            services.AddScoped<IDashboardService, DashboardService>();
        }

        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            MapperConfiguration mapperConfig = new MapperConfiguration(mapConfig => {
                mapConfig.AddProfile(new AutoMapperProfile());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

    }
}
