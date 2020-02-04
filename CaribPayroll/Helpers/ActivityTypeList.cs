using CaribPayroll.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaribPayroll.Helpers
{
    public class ActivityTypeList
    {
        public static List<ActivityTypeList> activity = new List<ActivityTypeList>();
        public ActivityTypeList()
        {

        }
        public ActivityTypeList(string ActivityType)
        {
            this.ActivityType = ActivityType;
        }

        public static List<ActivityTypeList> GetAllRecords()
        {
            if (activity.Count() == 0)
            {

                activity.Add(new ActivityTypeList(ComparisonValues.activityFixed));
                activity.Add(new ActivityTypeList(ComparisonValues.activityActivity));

            }
            return activity;
        }
        public string ActivityType
        {
            get; set;
        }
    }
}
