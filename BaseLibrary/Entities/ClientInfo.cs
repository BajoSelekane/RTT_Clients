namespace BaseLibrary.Entities
{
    public class ClientInfo
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public required string Gender { get; set; }
    }
}
