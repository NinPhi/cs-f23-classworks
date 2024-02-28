namespace L24_EFCore_Navigation.Auth.Exceptions;

public class WrongCredentialsException : Exception
{
    public WrongCredentialsException()
        : base("Invalid credentials.") { }
}
