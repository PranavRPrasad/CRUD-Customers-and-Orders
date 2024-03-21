using System.ComponentModel.DataAnnotations;

namespace CustomersOrdersCRUDWeb.Models;

public partial class Customer
{
    [Key]
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string? Notes { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
