using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
namespace BlowOut_Checkpoint1.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        [Required]
        [Display(Name = "Client ID")]
        public int ClientID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "First name must be 1-30 characters long.")]
        [Display(Name = "Client First Name")]
        public string ClientFirstName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1, ErrorMessage = "Last name must be 1-30 characters long.")]
        [Display(Name = "Client Last Name")]
        public string ClientLastName { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Address must be 5-30 characters long.")]
        [Display(Name = "Client Address")]
        public string ClientAddress { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2, ErrorMessage = "First name must be 2-30 characters long.")]
        [Display(Name = "Client City")]
        public string ClientCity { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "State must be 2-20 characters long.")]
        [Display(Name = "Client State")]
        public string ClientState { get; set; }

        [Required]
        [StringLength(5, MinimumLength = 5, ErrorMessage = "Zip Code must be 5 characters long.")]
        [Display(Name = "Client Zip Code")]
        public string ClientZip { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Email must be 5-30 characters long.")]
        [Display(Name = "Client Email")]
        public string ClientEmail { get; set; }

        [Required]
        [Phone]
        [StringLength(20, MinimumLength = 7, ErrorMessage = "First name must be 7-20 characters long.")]
        [Display(Name = "Client Phone")]
        public string ClientPhone { get; set; }

        public int? InstrumentCode { get; set; }
        public virtual Instruments Instruments { get; set; }
    }
}