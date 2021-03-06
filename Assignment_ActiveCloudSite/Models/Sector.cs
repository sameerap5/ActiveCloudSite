﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment_ActiveCloudSite.Models
{
    public class Sector
    {
        [Key]
        public string name { get; set; }
        public string type { get; set; }
        public float? performance { get; set; }
        public float? lastUppdated { get; set; }
    }
}
