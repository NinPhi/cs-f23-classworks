using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace L27_InputValidation.Validation.Attributes;

public class MinAttribute : ValidationAttribute
{
    public int Minimum { get; set; }

    public MinAttribute(int minValue)
    {
        Minimum = minValue;
    }

    public override bool IsValid(object? value)
    {
        if ((int?)value < Minimum)
            return false;

        return true;
    }

    public override string FormatErrorMessage(string name)
    {
        return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, Minimum);
    }
}
