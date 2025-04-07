namespace Domain.Common.Entities;

public class HallTable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Table_Type_Id { get; set; }
    public int WeddingId { get; set; }

    public TableType TableType { get; set; }
    public Wedding Wedding { get; set; }
    public ICollection<HallTableGuest> Guests { get; set; }
}