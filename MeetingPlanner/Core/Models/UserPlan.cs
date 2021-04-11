using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Core.Models
{
    public class UserPlan
    {
        public int Id { get; set; }

        
        [Display(Name = "Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Początek pracy")]
        public DateTime WorkStart { get; set; }

        [Display(Name = "Koniec pracy")]
        public DateTime WorkEnd { get; set; }

        public List<DateTime> FreeTime { get; set; }

        public IEnumerable<Meeting> Meetings { get; set; }
    }
}
