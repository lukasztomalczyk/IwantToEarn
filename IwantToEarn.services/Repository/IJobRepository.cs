using System.Collections.Generic;
using IwantToEarn.services.DbModel;

namespace IwantToEarn.services.Repository
{
    public interface IJobRepository
    {
        JobModel GetJob(int _id);
        List<JobModel> GetAllJobsList();
        JobModel DeleteJob(JobModel _job);
        JobModel UpdateJob(JobModel _job);
        JobModel Create(JobModel _job);
    }
}