namespace docside_bookingview_2.ViewModels;

using docside_bookingview_2.Areas.Identity.Pages.Account;
using docside_bookingview_2.Models;
using System.Collections.Generic;

public class RegisterUserWithCompany
{
    public RegisterModel RegisterModel { get; set; }
    public IEnumerable<Company> Companies { get; set; }
    public string ReturnUrl { get; set; }
}
