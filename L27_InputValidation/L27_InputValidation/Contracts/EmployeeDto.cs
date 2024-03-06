using L27_InputValidation.Enums;
using L27_InputValidation.Validation;
using L27_InputValidation.Validation.Attributes;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L27_InputValidation.Contracts;

public record EmployeeDto
{
    [DisplayName("[ФИО]")]
    [Required(AllowEmptyStrings = false, ErrorMessage = Messages.REQUIRED)]
    [StringLength(200, ErrorMessage = Messages.STRING_LENGTH)]
    public string? FullName { get; init; }

    [DisplayName("[Адрес почты]")]
    [EmailAddress(ErrorMessage = "Поле {0} не является корректным адресом почты.")]
    [Required(AllowEmptyStrings = false, ErrorMessage = Messages.REQUIRED)]
    [StringLength(150, MinimumLength = 3, ErrorMessage = Messages.STRING_LENGTH)]
    public string? Email { get; init; }

    [DisplayName("[Номер телефона]")]
    [Phone(ErrorMessage = "Поле {0} не является корректным номером телефона.")]
    [Required(AllowEmptyStrings = false, ErrorMessage = Messages.REQUIRED)]
    [StringLength(20, ErrorMessage = Messages.STRING_LENGTH)]
    public string? Phone { get; init; }

    [DisplayName("[Позиция сотрудника]")]
    [Required(ErrorMessage = Messages.REQUIRED)]
    [EnumDataType(typeof(Position), ErrorMessage = "Формат поля {0} указан некорректно.")]
    public Position? Position { get; init; }

    [DisplayName("[Зарплата сотрудника]")]
    [Required(ErrorMessage = Messages.REQUIRED)]
    [Range(0, 10000000, ErrorMessage = Messages.RANGE)]
    public decimal? Salary { get; init; }

    [DisplayName("[Опыт работы]")]
    [Required(ErrorMessage = Messages.REQUIRED)]
    [Min(0, ErrorMessage = Messages.MIN)]
    public int? YearsExperience { get; init; }

    [DisplayName("[Дата трудоустройства]")]
    [Required(ErrorMessage = Messages.REQUIRED)]
    public DateTime? DateOfEmployment { get; init; }
}
