using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Core.Models
{
    public class Calendar
    {
        public IEnumerable<UserPlan> UserPlanns { get; set; }
    }
}
