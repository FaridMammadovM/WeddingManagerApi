namespace Domain.Common.Entities;

public class RestaurantHall
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int MinCount { get; set; }
    public int MaxCount { get; set; }
    public int ResId { get; set; }
    public bool IsActive { get; set; }

    public Restaurant Restaurant { get; set; }
}