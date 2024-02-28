namespace L24_EFCore_Navigation.Auth.Exceptions;

public class PasswordTooShortException : Exception
{
    public PasswordTooShortException(int minLength)
        : base($"Password should be at least {minLength} characters long.") { }
}
