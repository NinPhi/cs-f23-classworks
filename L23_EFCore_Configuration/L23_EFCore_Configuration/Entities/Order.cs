using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace L23_EFCore_Configuration.Entities;

public class Order
{
    public long Id { get; set; }

    public long CustomerId { get; set; }

    public required string ItemName { get; set; }

    public required int Quantity { get; set; }

    public required Item Item { get; set; }
}
