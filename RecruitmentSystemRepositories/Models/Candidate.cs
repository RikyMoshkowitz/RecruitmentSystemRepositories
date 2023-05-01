
using System;
using System.Collections.Generic;


#nullable disable

namespace RecruitmentSystemRepositories.Models
{
    public partial class Candidate
    {
        public Candidate()
        {
            WorkerLanguages = new HashSet<WorkerLanguage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? BeginYear { get; set; }
        public DateTime? LastUpdateDate { get; set; }

        public virtual ICollection<WorkerLanguage> WorkerLanguages { get; set; }


    }
}
