namespace Domain.Common.Entities;

public class TableType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }

    public ICollection<HallTable> HallTables { get; set; }
    public ICollection<ResTableLimit> TableLimits { get; set; }
}