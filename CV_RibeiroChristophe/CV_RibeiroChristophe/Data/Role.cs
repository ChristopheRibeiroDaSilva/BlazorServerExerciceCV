﻿using System.ComponentModel.DataAnnotations;

namespace CV_RibeiroChristophe.Data
{
    public class Role
    {
        public int Id { get; set; }
        [Required]
        public string? name { get; set; }
    }
}
