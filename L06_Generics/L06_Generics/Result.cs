namespace L6_Generics;

public class Result<TValue>
{
    public bool IsError => Error != null;
    public bool IsSuccess => !IsError;
    public string? Error { get; set; }
    public TValue? Value { get; set; }

    public TValue GetValue()
    {
        return Value;
    }
}
