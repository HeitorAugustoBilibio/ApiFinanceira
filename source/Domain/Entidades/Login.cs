namespace Domain.Entidades;

public class Login
{
    public Usuario Usuario { get; set; }
    public string? Token { get; set; }
    public DateTime Expiration { get; set; }
    public string? Error { get; set; }
}
