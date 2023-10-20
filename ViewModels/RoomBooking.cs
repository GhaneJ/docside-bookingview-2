namespace docside_bookingview_2.ViewModels;

using docside_bookingview_2.Areas.Identity.Data;
using docside_bookingview_2.Models;
using System.Collections.Generic;

public class RoomBooking
{
    public Room Room { get; set; }
    public Booking Booking { get; set; }
    public List<User> Users { get; set; }
}
