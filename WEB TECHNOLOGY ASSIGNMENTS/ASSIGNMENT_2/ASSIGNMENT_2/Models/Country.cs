using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASSIGNMENT_2.Models
{
    public class Country
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string CountryName { get; set; }
        [Required]
        public string Capital { get; set; }
    }
}