namespace L46_Patterns.Strategy;

public class Driver(ICar car)
{
    public void DriveCar()
    {
        car.Drive();
    }
}

public interface ICar
{
    public void Drive();
}
