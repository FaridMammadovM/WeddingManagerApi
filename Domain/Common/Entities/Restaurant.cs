namespace Domain.Common.Entities;

public class Restaurant
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public string Location { get; set; }

    public ICollection<RestaurantPhone> Phones { get; set; }
    public ICollection<RestaurantUser> Users { get; set; }
    public ICollection<RestaurantHall> Halls { get; set; }
    public ICollection<ResTableLimit> TableLimits { get; set; }
}