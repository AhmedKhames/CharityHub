namespace CharityHub.Domain.Entities;

public class UserSession
{
    public string RefreshToken { get; set; }
    public int UserId { get; set; }
}