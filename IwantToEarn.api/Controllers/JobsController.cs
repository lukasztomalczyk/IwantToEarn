using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IwantToEarn.services;
using Microsoft.AspNetCore.Mvc;

namespace IwantToEarn.api.Controllers
{
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly IJobRepository _context;
        public JobsController(IJobRepository _context)
        {
            this._context = _context;
        }

        [HttpGet]
        public string Index()
        {
            return "działa";
        }

        [HttpGet("{id}")]
        public JobModel Get(int id)
        {
           return _context.GetJob(id);
        }
    }
}
