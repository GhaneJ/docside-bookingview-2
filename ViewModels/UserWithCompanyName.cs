namespace docside_bookingview_2.ViewModels;

using System.ComponentModel;

public class UserWithCompanyName
{
    public string Id { get; set; }
    [DisplayName("Förnamn")]
    public string FirstName { get; set; }
    [DisplayName("Efternamn")]
    public string LastName { get; set; }
    [DisplayName("Email")]
    public string Email { get; set; }
    [DisplayName("Företagsnamn")]
    public string CompanyName { get; set; }
    [DisplayName("Telefonnummer")]
    public string PhoneNumber { get; set; }
    [DisplayName("Aktiv")]
    public bool Active { get; set; }
}
