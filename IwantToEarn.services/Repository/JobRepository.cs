using System.Collections.Generic;
using System.Linq;
using IwantToEarn.services.DbModel;

namespace IwantToEarn.services.Repository
{
    public class JobRepository : IJobRepository
    {
        private DbApplicationContext _context;
        public JobRepository(DbApplicationContext _context)
        {
            this._context = _context;
        }

        public JobModel DeleteJob(JobModel _job)
        {
            throw new System.NotImplementedException();
        }

        public List<JobModel> GetAllJobsList()
        {
            var _jobs = _context.JobModels.ToList();
            return _jobs;
        }

        public JobModel GetJob(int _id)
        {
            return _context.JobModels.FirstOrDefault(a => a.Id == _id);
        }

        public JobModel UpdateJob(JobModel _job)
        {
            throw new System.NotImplementedException();
        }

        public JobModel Create(JobModel _job)
        {
             _context.JobModels.Add(_job);
             _context.SaveChanges();
             return _job;
        }
    }
}