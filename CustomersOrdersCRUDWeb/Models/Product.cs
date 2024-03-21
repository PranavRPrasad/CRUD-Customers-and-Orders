namespace CustomersOrdersCRUDWeb.Models;

public partial class Product
{
    public int CookieId { get; set; }

    public string CookieName { get; set; } = null!;

    public decimal RevenuePerCookie { get; set; }

    public decimal CostPerCookie { get; set; }
}
