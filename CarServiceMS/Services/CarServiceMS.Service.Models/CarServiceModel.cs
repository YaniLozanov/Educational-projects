﻿using CarServiceMS.Data.Attributes;
using CarServiceMS.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarServiceMS.Service.Models
{
    public class CarServiceModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [RegularExpression("^[А-ЯA-Z]{1,2}[А-ЯA-Z0-9]{2,6}$", ErrorMessage = "Invalid Number!")]
        [CarNumberUnique]
        public string Number { get; set; }
        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime YearFrom { get; set; }

        [Required]
        public DateTime RegistredOn { get; set; } = DateTime.Now;

        [Required]
        public ApplicationUserServiceModel Owner { get; set; }


    }
}
