﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAS_LMS.Models
{
    public class Module
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Module Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        [Display(Name = "Activities")]
        public virtual ICollection<Activity> ModuleActivities { get; set; }
    }
}