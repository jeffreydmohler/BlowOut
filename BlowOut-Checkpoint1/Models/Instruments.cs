using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace BlowOut_Checkpoint1.Models
{
    [Table("Instruments")]
    public class Instruments
    {
        [Key]
        [Required]
        public int InstrumentCode { get; set; }

        [Required(ErrorMessage = "Please specify Instrument Name")]
        [Display(Name = "Instrument")]
        public string InstrumentName { get; set; }

        [Required (ErrorMessage = "Please specify if New or Used")]
        [Display(Name = "New or Used?")]
        public string InstrumentType { get; set; }

        [Required(ErrorMessage = "Please specify Price")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        
        public int? ClientID { get; set; }
    }
}