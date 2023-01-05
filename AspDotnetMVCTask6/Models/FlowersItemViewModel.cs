using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotnetMVCTask6.Models
{
    public class FlowersItemViewModel
    {
        [Display(Name = "Id")]
        public int Id { get; set; }

        [Display(Name = "FlowerName")]
        public string Name { get; set; }

        [Display(Name = "Image Url")]
        public string ImageUrl { get; set; }

    }
}
