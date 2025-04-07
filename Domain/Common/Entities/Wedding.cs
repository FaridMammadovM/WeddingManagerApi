namespace Domain.Common.Entities;

public class Wedding
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public DateTime Date { get; set; }

    public Client Client { get; set; }
    public ICollection<HallTable> HallTables { get; set; }
}