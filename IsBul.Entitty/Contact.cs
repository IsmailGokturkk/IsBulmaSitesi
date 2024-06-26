﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBul.Entitty
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public  string Subject { get; set; }
        [StringLength(1000)]
        public string Message { get; set; }


    }
}
