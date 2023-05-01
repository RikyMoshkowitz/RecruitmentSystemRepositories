using System;
using System.Collections.Generic;

#nullable disable

namespace RecruitmentSystemRepositories.Models
{
    public partial class WorkerLanguage
    {
        public int CandidateId { get; set; }
        public int LanguageId { get; set; }
        public int? Number { get; set; }

        public virtual Candidate Candidate { get; set; }
        public virtual Language Language { get; set; }
    }
}
