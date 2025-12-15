namespace noMoreAzerty_back.DTOs.Response
{
    public class VaultResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public VaultUserResponseDto User { get; set; } = null!;
    }
}
