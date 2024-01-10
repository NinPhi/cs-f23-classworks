namespace L6_Generics.Classwork;

internal class AsylTash : IBuilding<ConcreteMaterial>
{
    public ConcreteMaterial Material { get; set; }

    public AsylTash(ConcreteMaterial material)
    {
        Material = material;
    }
}
