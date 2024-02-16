namespace L6_Generics.Classwork;

internal interface IBuilding<TMaterial>
    where TMaterial : Material
{
    public TMaterial Material { get; set; }
}
