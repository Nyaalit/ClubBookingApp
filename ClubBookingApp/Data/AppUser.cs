using Microsoft.AspNetCore.Identity;

namespace ClubBookingApp.Data
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Reservations = new HashSet<Reservation>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
