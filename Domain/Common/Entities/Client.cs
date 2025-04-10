namespace Domain.Common.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public ICollection<Wedding> Weddings { get; set; }
}