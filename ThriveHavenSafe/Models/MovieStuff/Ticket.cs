using System.ComponentModel.DataAnnotations.Schema;
using ThriveHavenSafe.Models.CartStuff;

namespace ThriveHavenSafe.Models.MovieStuff
{

    public class Ticket
    {
        public int TicketId { get; set; }

        public int Cost { get; set; } = 10;

        public int Quantity { get; set; }

        public string ticketDate { get; set; }

        public string ticketTime { get; set; }

        public int MovieId { get; set; }


        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }

        public int? CartId { get; set; }

        [ForeignKey("CartId")]

        public Cart Cart
        {
            get; set;

        }

        public int? OrderId { get; set; }

        [ForeignKey("Id")]
        public Order Order { get; set; }

    }
    
}
