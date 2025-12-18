namespace noMoreAzerty_dto.DTOs.Response
{
    public class GetVaultResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public VaultUserResponse User { get; set; } = null!;
    }
}
