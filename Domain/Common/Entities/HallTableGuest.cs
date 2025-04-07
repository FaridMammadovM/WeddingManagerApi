namespace Domain.Common.Entities;

public class HallTableGuest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ChairNumber { get; set; }
    public int Hall_Table_Id { get; set; }

    public HallTable HallTable { get; set; }
}