﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TelephoneAPI.Models
{
    public class Telephone
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(9)")]
        public string number { get; set; }

    }
}
