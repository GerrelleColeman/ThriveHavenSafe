﻿using System.ComponentModel.DataAnnotations.Schema;
using ThriveHavenSafe.Models.AccountStuff;

namespace ThriveHavenSafe.Models.CartStuff
{
    public class Cart
    {
        public int CartId { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey("UserId")]
        public Users User { get; set; }

    }
}
