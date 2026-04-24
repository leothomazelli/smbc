namespace TSI.SMBC.Contracts.Models.DTOs
{
    public class PropertyDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string Locality { get; set; }
        public string Parish { get; set; }
        public string Municipality { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
    }
}
