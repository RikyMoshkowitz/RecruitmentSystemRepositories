using Microsoft.EntityFrameworkCore;
using RecruitmentSystemRepositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RecruitmentSystemRepositories.Interfaces
{
    public interface IContext
    {
         DbSet<Candidate> Candidates { get; set; }
         DbSet<Language> Languages { get; set; }
        DbSet<WorkerLanguage> WorkerLanguages { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

    }
}
