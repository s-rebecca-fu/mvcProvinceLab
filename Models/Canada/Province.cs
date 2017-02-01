using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanadaLab.Models.Canada
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code"), Required]
        public string ProvinceCode { get; set; }

        [Display(Name = "Province"), Required]
        public string ProvinceName { get; set; }

        public List<City> Cities { get; set; }
    }
}