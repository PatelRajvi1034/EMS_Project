﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMS_Project.Data_Layer.Models
{
    public class Timesheet
    {
        [Key]
        public int TimesheetId { get; set; }

        [Required]
        public int EmployeeId { get; set; }

        [Required]

        public DateTime Date { get; set; }

        [Required]

        public TimeSpan StartTime { get; set; }

        [Required]

        public TimeSpan EndTime { get; set; }

        [Required]

        public decimal TotalHours { get; set; }

        public string Description { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Navigation property
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
