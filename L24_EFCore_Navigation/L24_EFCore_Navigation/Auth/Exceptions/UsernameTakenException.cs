namespace L24_EFCore_Navigation.Auth.Exceptions;

public class UsernameTakenException : Exception
{
    public UsernameTakenException()
        : base("Username is already taken.") { }
}
