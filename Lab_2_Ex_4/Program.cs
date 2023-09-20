public class User : IUser, IUser1, IUser2, IUser3
{
    private string login;
    private string name;
    private string surname;
    private int age;
    private readonly DateTime creationDate;

    public User(string login, string name, string surname, int age)
    {
        this.login = login;
        this.name = name;
        this.surname = surname;
        this.age = age;
        this.creationDate = DateTime.Now;
    }

    public string Login
    {
        get { return login; }
    }

    public string Name
    {
        get { return name; }
    }

    public string Surname
    {
        get { return surname; }
    }

    public int Age
    {
        get { return age; }
    }

    public DateTime CreationDate
    {
        get { return creationDate; }
    }

    public void PrintInfo()
    {
        Console.WriteLine("Логiн: {0}", login);
        Console.WriteLine("Iм'я: {0}", name);
        Console.WriteLine("Прізвище: {0}", surname);
        Console.WriteLine("Вiк: {0}", age);
        Console.WriteLine("Дата заповнення анкети: {0}", creationDate);
    }
}
class Program
{
    static void Main(string[] args)
    {
        User user = new User("user1", "Артем", "Федоренко", 19);
        user.PrintInfo();
    }
}
