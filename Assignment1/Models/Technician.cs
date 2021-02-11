﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Assignment1.Models
{
    public class Technician
    {
        [Required(ErrorMessage = "Please enter a Technician name.")]
        public string techName { get; set; }

        [Required(ErrorMessage = "Please enter a Technician email.")]
        public string techEmail { get; set; }
        [Required(ErrorMessage = "Please enter a Technicians phone number.")]
        public string techPhone { get; set; }

        

        public Technician()
        {

        }
    }
}
