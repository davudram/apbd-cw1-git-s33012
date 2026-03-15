namespace FirstProject;

public class User
{
    public User(int id, string name, string surname, string emailUser, int ageUser)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.EmailUser = emailUser;
        this.AgeUser = ageUser;
    }

    public void Print()
    {
        Console.WriteLine($"Id: {this.Id}, Name: {this.Name},  Surname: {this.Surname}, Email: {this.EmailUser},  Age: {this.AgeUser}");
    }

    public bool IsAdult()
    {
        if (this.AgeUser >= 18)
            return true;
        else
            return false;
    }

    public bool IsRetired()
    {
        if (this.AgeUser >= 65)
            return true;
        else
            return false;
    }

    public bool IsValidEmail()
    {
        if (this.EmailUser.Contains("@") && this.EmailUser.Contains("."))
            return true;
        else
            return false;
    }

    public int AgeDifference(User other)
    {
        return this.AgeUser - other.AgeUser;
    }
    
    public bool IsOlderThan(int age)
    {
        return AgeUser > age;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string EmailUser { get; set; }
    public int AgeUser { get; set; }
}