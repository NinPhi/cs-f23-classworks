namespace LP10_LINQ.Entities;

public class Employee
{
    public long Id { get; set; }
    public string FullName { get; set; }
    public string Position { get; set; }
    public int Experience { get; set; }
    public bool IsOnVacation { get; set; }

    public Employee(
        long id,
        string fullName,
        string position,
        int experience,
        bool isOnVacation = false)
    {
        Id = id;
        FullName = fullName;
        Position = position;
        Experience = experience;
        IsOnVacation = isOnVacation;
    }
}
