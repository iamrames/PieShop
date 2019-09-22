using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RameshPieShop.Models
{
    public class Feedback
    {
        [BindNever]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your Name is Required.")]
        public string Name { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Your Email is Required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(5000, ErrorMessage = "Your Message is Required.")]
        public string Message { get; set; }
        public bool ContactMe { get; set; }
    }
}
