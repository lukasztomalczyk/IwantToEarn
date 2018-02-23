using System.Collections.Generic;
using System.Linq;

namespace IwantToEarn.services
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
            throw new System.NotImplementedException();
        }

        public JobModel GetJob(int _id)
        {
            return _context.JobModels.FirstOrDefault(a => a.Id == _id);
        }

        public JobModel UpdateJob(JobModel _job)
        {
            throw new System.NotImplementedException();
        }
    }
}