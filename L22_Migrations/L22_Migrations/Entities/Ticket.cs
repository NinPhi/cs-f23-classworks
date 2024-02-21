namespace L22_Migrations.Entities;

public class Ticket
{
    public long Id { get; set; }
    public required long MovieId { get; set; }
    public required string Hall { get; set; }
    public required int RowNumber { get; set; }
    public required int SeatNumber { get; set; }

    public Movie? Movie { get; set; }
}
