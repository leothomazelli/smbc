namespace TSI.SMBC.Contracts.Models;

public class Material : BaseModel
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public decimal Weight { get; set; }
    public decimal Value { get; set; }
    public string Category { get; set; }
}
