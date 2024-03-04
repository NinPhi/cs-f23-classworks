using L26_Reflection.Attributes;

namespace L26_Reflection.Enums;

public enum CarType
{
    [Russian("Хэтчбэк")]
    Hatchback = 0,

    [Russian("Внедорожник")]
    SUV = 1,

    [Russian("Седан")]
    Sedan = 2,
}
