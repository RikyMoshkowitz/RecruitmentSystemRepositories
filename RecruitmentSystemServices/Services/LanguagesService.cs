using AutoMapper;
using RecruitmentSystemCommon.Dto_s;
using RecruitmentSystemRepositories.Interfaces;
using RecruitmentSystemRepositories.Models;
using RecruitmentSystemServices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecruitmentSystemServices.Services
{
    class LanguagesService : IService<LanguagesDto>
    {
        private readonly IRepository<Language> LanRepository;
        private readonly IMapper mapper;
        public LanguagesService(IRepository<Language> repository,IMapper mapper)
        {
            this.LanRepository = repository;
            this.mapper = mapper;
        }
        public async Task<List<LanguagesDto>> GetAllAsync()
        {
            var listLanguages= await LanRepository.GetAllAsync();
            return this.mapper.Map<List<LanguagesDto>>(listLanguages);
        }

        public async Task<LanguagesDto> getById(int id)
        {
            var Languages = await LanRepository.GetByIdAsync(id);
            return this.mapper.Map<LanguagesDto>(Languages);
        }
    }
}
