namespace noMoreAzerty_dto.DTOs.Response
{
    public class VaultEntryHistoryItemResponse
    {
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime CreatedAt { get; set; }
        public Guid VaultId { get; set; }
        public Guid EntryId { get; set; }
    }
}
