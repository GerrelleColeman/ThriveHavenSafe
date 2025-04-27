namespace ThriveHavenSafe.Models.AccountStuff
{
    public class PreferencesViewModel
    {
        public Payment NewPayment { get; set; } = new Payment();
        public List<Payment> SavedPayments { get; set; } = new List<Payment>();
    }
}
