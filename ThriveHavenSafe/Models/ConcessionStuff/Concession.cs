﻿using System.ComponentModel.DataAnnotations;

namespace ThriveHavenSafe.Models.ConcessionStuff
{
    public class Concession
    {
        [Key]
        public int ItemID { get; set; }
        public String ItemName { get; set; }
        public double Cost { get; set; }
        public string ImageUrl { get; set; }
    }
}
