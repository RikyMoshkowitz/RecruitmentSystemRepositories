using AutoMapper;
using RecruitmentSystemCommon.Dto_s;
using RecruitmentSystemRepositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemServices
{
    class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<LanguagesDto, Language>().ReverseMap();
            CreateMap<CandidatesDto, Candidate>().ReverseMap();
        }
    }
}
