using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CanadaLab.Models.Canada
{
    public class City
    {
        //[Key]
        public int CityId { get; set; }

        [Display(Name = "City"), Required]
        public string CityName { get; set; }
        public int Popuation { get; set; }
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}