namespace L10_LINQ.Entities;

public class Employee
{
    public Employee(
        long id,
        string firstName,
        string lastName,
        string position,
        int experience,
        bool isOnVacation)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Position = position;
        Experience = experience;
        IsOnVacation = isOnVacation;
    }

    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }
    public bool IsOnVacation { get; set; }

    public Pet Pet { get; set; }
}
