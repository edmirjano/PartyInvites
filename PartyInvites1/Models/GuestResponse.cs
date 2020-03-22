using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites1.Models
{
    public class GuestResponse
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string Emri { get; set; }
        [Required(ErrorMessage = "Please enter your subname")]
        public string Mbiemri { get; set; }
        [Required(ErrorMessage = "Please enter your gender")]
        [RegularExpression("^(M|F)$",ErrorMessage = "Please enter your gender M or F")]
        public string Gjnia { get; set; }
        [Required(ErrorMessage = "Please specify your presence")]
        public bool DoVije { get; set; }
    }
}