using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlowOut_Checkpoint1.Models
{
    public class Rentals
    {
        [Required]
        public int InstrumentCode { get; set; }

        [Required(ErrorMessage = "Please specify Instrument Name")]
        [Display(Name = "Instrument")]
        public string InstrumentName { get; set; }

        [Required(ErrorMessage = "Please specify New Price")]
        [Display(Name = "New")]
        public string NewPrice { get; set; }

        [Display(Name = "Used")]
        public string UsedPrice { get; set; }
    }
}