﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Models
{
    public class CoverType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
