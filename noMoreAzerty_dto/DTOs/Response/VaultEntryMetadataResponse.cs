namespace noMoreAzerty_dto.DTOs.Response
{
	public class VaultEntryMetadataResponse
	{
		public Guid Id { get; set; }
		public string? CipherTitle { get; set; }
		public string? TitleIV { get; set; }
		public string? TitleTag { get; set; }
		public DateTime? CreatedAt { get; set; }
		public DateTime? UpdatedAt { get; set; }
	}
}
