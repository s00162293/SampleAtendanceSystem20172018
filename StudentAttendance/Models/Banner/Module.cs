﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentAttendance.Models.Banner
{
    public class Module
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Enrollment> Enrollements { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }

    }
}