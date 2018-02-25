using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using IwantToEarn.services;
using Microsoft.AspNetCore.Mvc;

namespace IwantToEarn.api.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private IJobRepository _jobRepository;
        public JobsController(IJobRepository jobRepository)
        {
            this._jobRepository = jobRepository;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if(id!=0)
            {
                var _jobModel = _jobRepository.GetJob(id);
                return StatusCode(200, _jobModel);
            }
            else
            {
                return StatusCode(404, "Błędny ID");
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody] JobModel _model)
        {
            if(ModelState.IsValid)
            {
                 var _addJob = _jobRepository.Create(_model);
                 return StatusCode(200, _model);
            }
            else
            {
                return StatusCode(404, "bład");
            }
        }
    }
}
