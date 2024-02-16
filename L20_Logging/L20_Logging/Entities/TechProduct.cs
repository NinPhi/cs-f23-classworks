namespace L20_Logging.Entities;

public class TechProduct
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Cost { get; set; }

    public TechProduct(string name, int quantity, decimal cost)
    {
        Name = name;
        Quantity = quantity;
        Cost = cost;
    }
}
