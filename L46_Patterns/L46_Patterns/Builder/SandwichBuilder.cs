namespace L46_Patterns.Builder;

public class SandwichBuilder
{
    private readonly List<Ingredient> _ingredients = [ Ingredient.Bread ];

    public Sandwich Build()
    {
        _ingredients.Add(Ingredient.Bread);

        return new Sandwich() { Ingredients = _ingredients };
    }

    public SandwichBuilder AddChicken()
    {
        _ingredients.Add(Ingredient.Chicken);

        return this;
    }

    public SandwichBuilder AddCheese()
    {
        _ingredients.Add(Ingredient.Cheese);

        return this;
    }

    public SandwichBuilder AddTomato()
    {
        _ingredients.Add(Ingredient.Tomato);

        return this;
    }

    public SandwichBuilder AddSalad()
    {
        _ingredients.Add(Ingredient.Salad);

        return this;
    }
}
