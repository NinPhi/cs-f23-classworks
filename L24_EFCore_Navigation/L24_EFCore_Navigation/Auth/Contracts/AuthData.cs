namespace L24_EFCore_Navigation.Auth.Contracts;

public class AuthData
{
    private string username = string.Empty;
    public required string Username
    {
        get => username;
        set => username = value.Trim().ToLower();
    }

    private string password = string.Empty;
    public required string Password
    {
        get => password;
        set => password = value.Trim();
    }
}