namespace TSI.SMBC.Contracts.Models
{
    public class Construction : BaseModel
    {
        public Master Master { get; set; }
        public DateTime DueDate { get; set; }
        public IList<Material> Materials { get; set; }
        public Quotation Quotation { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}
