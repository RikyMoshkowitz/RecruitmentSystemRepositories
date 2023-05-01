using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemCommon.Dto_s
{
   public  class CandidatesDto
    { 

        public int Id { get; set; }
        public string Name { get; set; }
        public int? BeginYear { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public string allLanguages { get; set; }

       
    }
}
   