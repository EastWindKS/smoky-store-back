﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    [Table("Companies", Schema = "Tobacco")]
    public class Company
    {
       
        public int CompanyId { get; set; }
        
        public string CompanyName { get; set; }
        
        public string ImgUrl { get; set; }

        public List<Strength> Strengths { get; set; }
    }
}
