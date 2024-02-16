namespace L3_ExceptionHandling.Exceptions;

internal class CannotDivideByThreeException : Exception
{
    public CannotDivideByThreeException() : base(
        "Запрещено делить на три!")
    { }
}
