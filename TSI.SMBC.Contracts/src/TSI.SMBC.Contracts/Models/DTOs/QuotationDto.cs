namespace TSI.SMBC.Contracts.Models.DTOs
{
    public class QuotationDto
    {
        public Guid Id { get; set; }
        public decimal Value { get; set; }
        public DateTime Date { get; set; }
    }
}
