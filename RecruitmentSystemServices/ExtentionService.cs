using Microsoft.Extensions.DependencyInjection;
using RecruitmentSystemServices.Services;
using RecruitmentSystemServices.interfaces;
using RecruitmentSystemRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecruitmentSystemRepositories.Interfaces;
using RecruitmentSystemRepositories.Models;
using RecruitmentSystemCommon.Dto_s;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace RecruitmentSystemServices
{
   public static class ExtentionService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService<CandidatesDto>, CandidatesService>();
            services.AddScoped<IService<LanguagesDto>, LanguagesService>();
            services.AddSingleton<IContext, RecruitmentSystemContext>();
            services.AddAutoMapper(typeof(Mapper));


        }
    }

}
