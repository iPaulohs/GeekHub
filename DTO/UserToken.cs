namespace GeekHub.DTO
{
    public record UserToken
    {
        public bool Authenticated { get; init; }
        public DateTime Expiration { get; init; }
        public string? Token { get; init; }
        public string? Message { get; init; }
        public string UserId { get; init; }
        public string UserName { get; init; }
    }
}
