using CashVan.Repositry;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashVan.Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<ISettingService, SettingService>();
            //services.AddScoped<ILookupService, LookupService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IAgentService, AgentService>();
            //services.AddScoped<ICompetitionService, CompetitionService>();
            //services.AddScoped<ICommonQuestionService, CommonQuestionService>();
            //services.AddScoped<INotificationService, NotificationService>();
            services.AddRepositry(configuration);
            return services;
        }
    }
}
