namespace Domain.Common.Entities;

public class RestaurantPhone
{
    public int Id { get; set; }
    public string Phone { get; set; }
    public int ResId { get; set; }

    public Restaurant Restaurant { get; set; }
}