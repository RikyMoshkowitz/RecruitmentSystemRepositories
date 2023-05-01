using Microsoft.Extensions.DependencyInjection;
using RecruitmentSystemRepositories.Interfaces;
using RecruitmentSystemRepositories.Models;
using RecruitmentSystemRepositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemRepositories
{
    public static class ExtentionRepository
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository<Candidate>, CandidatesRepositories>();
            services.AddScoped<IRepository<Language>, LanguagesRepositories>();
        }
    }
}