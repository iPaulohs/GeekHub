namespace GeekHub.DTO
{
    public record UserDTOLogin
    {
        public string? Email { get; init; }
        public string? Password { get; init; }  
        public string? ConfirmPassword { get; init; }
    }
}

