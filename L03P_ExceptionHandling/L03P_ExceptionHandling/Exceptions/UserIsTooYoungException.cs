namespace L2_ExceptionHandling.Exceptions;

internal class UserIsTooYoungException : Exception
{
    public UserIsTooYoungException() : base(
        "User must be at least 18 years old.")
    {
    }
}
