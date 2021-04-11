using System;
using System.ComponentModel.DataAnnotations;

namespace MeetingPlanner.Core.Models
{
    public class Meeting
    {
        public int Id { get; set; }

        
        [Display(Name="Nazwa")]
        public string Name { get; set; }

        [Display(Name = "Początek")]
        public DateTime Start { get; set; }

        [Display(Name = "Koniec")]
        public DateTime End { get; set; }

    }
}