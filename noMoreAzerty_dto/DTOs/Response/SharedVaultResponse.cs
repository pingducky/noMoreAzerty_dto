namespace noMoreAzerty_dto.DTOs.Response
{
    public class SharedVaultResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public VaultUserResponse Owner { get; set; } = null!;
    }
}
