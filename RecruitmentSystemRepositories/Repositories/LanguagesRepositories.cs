using Microsoft.EntityFrameworkCore;
using RecruitmentSystemRepositories.Interfaces;
using RecruitmentSystemRepositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemRepositories.Repositories
{
    class LanguagesRepositories : IRepository<Language>
    {
        private readonly IContext context;
        public LanguagesRepositories(IContext context)
        {
            this.context = context;
        }
        public async Task<List<Language>> GetAllAsync()
        {
            return await this.context.Languages.ToListAsync();
        }

        public async  Task<Language> GetByIdAsync(int id)
        {
            return await this.context.Languages.SingleAsync(x => x.Id == id);
        }

       
        }
    
}
