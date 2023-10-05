namespace OOP_itsystem;

public class User
{
    public string FirstName;
    public string LastName;
    public readonly string Username;
    public string Email;
    public string DOB;
    private string _password;

    // Constructor till Readonly
    // Ny måste alla klasser ha en konstruktor
    public User(string username, string email)
    {
        Username = username;
        Email = email;
    }

    public int Age()
    {
        throw new NotImplementedException();
    }
}
