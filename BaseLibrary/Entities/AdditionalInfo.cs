using System.ComponentModel.DataAnnotations;


namespace BaseLibrary.Entities
{
    public class AdditionalInfo
    {
        public int Id { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }
        public required string HomeAddress { get; set; }
        public string? WorkAddress { get; set; }
        public required string ContactNumber { get; set; }
        public string? AlternativeContactNum { get; set; }
    }
}
