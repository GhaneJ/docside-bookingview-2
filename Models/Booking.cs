namespace docside_bookingview_2.Models;

using docside_bookingview_2.Areas.Identity.Data;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Booking
{
    [Key]
    public int Id { get; set; }
    [Required]
    [DisplayName("Bokningsstart")]
    public DateTime datStartBooking { get; set; }
    [Required]
    [DisplayName("Bokningsslut")]
    public DateTime datEndBooking { get; set; }

    public DateTime datTimeOfBooking { get; set; }
    public double dblBookingPrice { get; set; }
    public User User { get; set; }
    public Room Room { get; set; }
}
