using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecruitmentSystemCommon.Dto_s;
using RecruitmentSystemServices.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecruitmentSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase

        {
            readonly IService<LanguagesDto> _service;
            public LanguageController(IService<LanguagesDto> service)
            {
                _service = service;
            }
            [HttpGet]
            public async Task<IEnumerable<LanguagesDto>> Get()
            {
                return await _service.GetAllAsync();
            }
            [HttpGet("{id}")]
            public async Task<LanguagesDto> GetById(int id)
            {
                return await _service.getById(id);
            }

        }
    }
