using System;
using System.Collections.Generic;

#nullable disable

namespace RecruitmentSystemRepositories.Models
{
    public partial class Language
    {
        public Language()
        {
            WorkerLanguages = new HashSet<WorkerLanguage>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<WorkerLanguage> WorkerLanguages { get; set; }
    }
}
