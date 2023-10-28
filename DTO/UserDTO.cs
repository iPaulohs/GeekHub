namespace GeekHub.DTO
{
    public record UserDTO
    {
        public string? Username { get; init; }
        public string? Name { get; init; }
        public string? Email { get; init; }
        public string? Password { get; init; }  
        public string? ConfirmPassword { get; init; }
        public DateTime BirthDate { get; init; }
        public string? CPF { get; init; }
    }
}

