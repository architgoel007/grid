﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace grid.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}
