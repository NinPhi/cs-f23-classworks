namespace L46_Patterns.Builder;

public class Sandwich
{
    public List<Ingredient> Ingredients { get; init; } = [];

    public void Eat()
    {
        Console.WriteLine("Мм, ням-ням!");
        Console.WriteLine("Сэндвич состоял из следующих ингредиентов:");

        var ingredients = string.Join(", ", Ingredients.Select(i => i.ToString()));

        Console.WriteLine(ingredients);
    }
}
