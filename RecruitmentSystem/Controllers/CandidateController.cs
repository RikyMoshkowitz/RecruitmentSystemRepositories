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
    public class CandidateController : ControllerBase
    { 
            readonly IService<CandidatesDto> _service;
            public CandidateController(IService<CandidatesDto> service)
            {
                _service = service;
            }
            // GET: api/<ValuesController>
            [HttpGet]
            public async Task<IEnumerable<CandidatesDto>> Get()
            {
                return await _service.GetAllAsync();
            }

            // GET api/<ValuesController>/5
            [HttpGet("{id}")]
            public async Task<CandidatesDto> GetById(int id)
            {
                return await _service.getById(id);
            }

}
}
