namespace CustomersOrdersCRUDWeb.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int CustomerId { get; set; }

    public decimal OrderTotal { get; set; }

    public virtual Customer Customer { get; set; } = null!;
}
