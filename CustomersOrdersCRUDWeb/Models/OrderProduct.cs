namespace CustomersOrdersCRUDWeb.Models;

public partial class OrderProduct
{
    public int OrderId { get; set; }

    public int CookieId { get; set; }

    public int Quantity { get; set; }

    public virtual Product Cookie { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;
}
