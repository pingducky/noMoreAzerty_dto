namespace noMoreAzerty_back.DTOs.Response
{
    public class SharedVaultResponseDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public VaultUserResponseDto Owner { get; set; } = null!;
    }
}
