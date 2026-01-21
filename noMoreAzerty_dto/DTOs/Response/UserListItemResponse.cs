namespace noMoreAzerty_dto.DTOs.Response
{
    public class UserListItemResponse
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLogin { get; set; }
        public bool IsActive { get; set; }
    }
}
