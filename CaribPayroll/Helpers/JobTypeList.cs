using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Helpers
{
    public class JobTypeList
    {
        public static List<JobTypeList> job = new List<JobTypeList>();
        public JobTypeList()
        {

        }
        public JobTypeList(string JobType)
        {
            this.JobType = JobType;
        }

        public static List<JobTypeList> GetAllRecords()
        {
            if (job.Count() == 0)
            {

                job.Add(new JobTypeList("Regular"));
                job.Add(new JobTypeList("Overtime"));

            }
            return job;
        }
        public string JobType
        {
            get; set;
        }
    }

}

