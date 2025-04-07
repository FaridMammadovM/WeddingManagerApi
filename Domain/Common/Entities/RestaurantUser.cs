namespace Domain.Common.Entities;

public class RestaurantUser
{
    public int Id { get; set; }
    public int ResId { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public Restaurant Restaurant { get; set; }
}