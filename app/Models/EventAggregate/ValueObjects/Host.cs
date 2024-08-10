namespace app.Models.EventAggregate.ValueObjects;

// Will be mapped to complex property
public class Host
{
    public string Name { get; private set; } = string.Empty;
    public string Email { get; private set; } = string.Empty;
    public string ImageUrl { get; private set; } = string.Empty;
    private Host(
        string name,
        string email,
        string imageUrl)
    {
        Name = name;
        Email = email;
        ImageUrl = imageUrl;
    }

    public static Host Create(
        string name,
        string email,
        string imageUrl)
    {
        return new Host(
            name,
            email,
            imageUrl);
    }
}
