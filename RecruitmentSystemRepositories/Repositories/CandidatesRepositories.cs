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
    internal class CandidatesRepositories : IRepository<Candidate>
    {
        private readonly IContext context;
       public CandidatesRepositories(IContext context)
        {
            this.context = context;
        }

        public async Task<List<Candidate>> GetAllAsync()
        {
            return await this.context.Candidates.ToListAsync(); 
        }

        public async Task<Candidate> GetByIdAsync(int id)
        {
            return await this.context.Candidates.SingleAsync(x => x.Id == id);
        }
    }
}
