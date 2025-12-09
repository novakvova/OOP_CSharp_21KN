namespace MyUsersApp;

public class UserItemModel
{
    public string Id { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;

    public override string ToString()
    {
        string str = $"{Id}. {FirstName} {LastName} - {Email} - {Phone} - {Image}";
        return str;
    }
}
