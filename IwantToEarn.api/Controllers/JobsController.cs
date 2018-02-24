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

        [HttpGet]
        public string Index()
        {
            return "działa";
        }

       [HttpGet("{id}")]
        public JobModel Get(int id)
        {
           return _jobRepository.GetJob(id);
        }

        [HttpPost]
        public JobModel Create([FromBody] JobModel _model)
        {
           var _addJob = _jobRepository.Create(_model);
           return _addJob;
        }
    }
}
