using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace L23P_EFCore_Configuration.Entities;

public class Order
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    [StringLength(75)]
    public required string Item { get; set; }

    [Precision(10, 2)]
    public required decimal PricePerItem { get; set; }

    public required int Quantity { get; set; }

    public decimal TotalPrice => PricePerItem * Quantity;

    public Customer? Customer { get; set; }
}
