namespace L46_Patterns.FactoryMethod;

public interface ISecret
{
    public string SecretInfo { get; }

    public static ISecret Create<TSecret>() where TSecret : ISecret, new()
    {
        return new TSecret();
    }

    public static ISecret CreateFbi()
    {
        return new FbiSecret();
    }

    public static ISecret CreateKgb()
    {
        return new KgbSecret();
    }

    private class FbiSecret : ISecret
    {
        public string SecretInfo => "Марк Цукерберг возглавляет восстание ящеров.";
    }

    private class KgbSecret : ISecret
    {
        public string SecretInfo => "Виктор Цой жив.";
    }
}
