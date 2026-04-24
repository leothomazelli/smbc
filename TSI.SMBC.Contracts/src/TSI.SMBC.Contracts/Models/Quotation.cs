namespace TSI.SMBC.Contracts.Models
{
    public class Quotation : BaseModel
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
