namespace ClubBookingApp.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public virtual AppUser? User { get; set; }
        public DateTime ReservationStartDate { get; set; }
        public DateTime ReservationEndDate { get; set; }
        public int TableId { get; set; }
        public virtual Table? Table { get; set; }
        public string Description { get; set; }
    }
}