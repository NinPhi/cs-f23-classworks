using L27P_Validation.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L27P_Validation.Contracts;

public record UserDto
{
    [Required(ErrorMessage = "Поле {0} не может быть пустым.", AllowEmptyStrings = false)]
    [EmailAddress(ErrorMessage = "Поле {0} содержит некорректный формат.")]
    [StringLength(200, ErrorMessage = "Поле {0} не должно превышать {1} символов.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Поле {0} не может быть пустым.", AllowEmptyStrings = false)]
    [StringLength(150, ErrorMessage = "Поле {0} не должно превышать {1} символов.")]
    public string? FullName { get; set; }

    [DisplayName("Дата рождения")]
    [Required(ErrorMessage = "Поле {0} не может быть пустым.")]
    public DateTime? DateOfBirth { get; set; }

    [EnumDataType(typeof(Subscription), ErrorMessage = "Поле {0} содержит некорректный формат.")]
    public Subscription? Subscription { get; set; }
}
