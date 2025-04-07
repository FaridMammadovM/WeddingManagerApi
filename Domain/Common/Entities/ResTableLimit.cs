namespace Domain.Common.Entities;

public class ResTableLimit
{
    public int Id { get; set; }
    public int Table_Type_Id { get; set; }
    public int LimitCount { get; set; }
    public int ResId { get; set; }

    public TableType TableType { get; set; }
    public Restaurant Restaurant { get; set; }
}