namespace TSI.SMBC.Contracts.Models
{
    public class Master : BaseModel
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Iban { get; set; }
        public string Nif { get; set; }
    }
}
