using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RecruitmentSystemCommon.Dto_s;
using RecruitmentSystemRepositories.Interfaces;
using RecruitmentSystemRepositories.Models;
using RecruitmentSystemServices.interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecruitmentSystemServices
{
    internal class CandidatesService : IService<CandidatesDto>
    {
        private readonly IRepository<Candidate> CanRepository;
        private readonly IMapper mapper;
        public CandidatesService(IRepository<Candidate> repository, IMapper mapper)
        {
            CanRepository = repository;
            this.mapper = mapper;
        }
        RecruitmentSystemContext rec = new RecruitmentSystemContext();

        public async Task<CandidatesDto> getLanguage(Candidate candidate)
        {
            string allLanguage = "";

            List<WorkerLanguage> candidateWorkerLanguages = await rec.WorkerLanguages.ToListAsync();
            List<WorkerLanguage> cwl = candidateWorkerLanguages.FindAll(r => r.CandidateId == candidate.Id);

            foreach (var item in cwl)
            {
                Language x = await rec.Languages.SingleAsync(a => a.Id == item.LanguageId);
                allLanguage += x.Name + ", ";
            }

            allLanguage = allLanguage.Remove(allLanguage.Length - 2);

            var newCandidate = this.mapper.Map<CandidatesDto>(candidate);
            newCandidate.allLanguages = allLanguage;
            return newCandidate;
        }
        public async Task<List<CandidatesDto>> GetAllAsync()
        {
            List<Candidate> ListCandidate = await CanRepository.GetAllAsync();
            List<CandidatesDto> newList = new List<CandidatesDto>();

            foreach (Candidate cnd in ListCandidate)
            {
                CandidatesDto cdto = await getLanguage(cnd);
                newList.Add(cdto);
            }

            return newList;
        }

        public async Task<CandidatesDto> getById(int id)
        {
            Candidate candidate = await CanRepository.GetByIdAsync(id);
            return await getLanguage(candidate);
        }




    }
}
