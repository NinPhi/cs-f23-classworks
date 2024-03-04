using L26P_Reflection.Attributes;

namespace L26P_Reflection.Enums;

public enum Role
{
    [Translation("Администратор")]
    Admin = 0,

    [Translation("Модератор")]
    Moderator = 1,

    [Translation("Пользователь")]
    User = 2,

    [Translation("Наблюдатель")]
    Spectator = 3,
}
