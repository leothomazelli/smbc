namespace TSI.SMBC.Contracts.Models.DTOs
{
    public class MasterDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Iban { get; set; }
        public string Nif { get; set; }
    }
}
