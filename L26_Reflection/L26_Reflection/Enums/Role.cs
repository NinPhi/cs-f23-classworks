using L26_Reflection.Attributes;

namespace L26_Reflection.Enums;

public enum Role
{
    [Russian("Пользователь")]
    User = 0,

    [Russian("Администратор")]
    Admin = 1,

    [Russian("Модератор")]
    Moderator = 2,

    [Russian("Наблюдатель")]
    Spectator = 3,
}
