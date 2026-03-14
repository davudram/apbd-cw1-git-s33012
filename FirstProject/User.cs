namespace FirstProject;

public class User
{
    public User(int id, string name, string surname, string email, int age)
    {
        this.Id = id;
        this.Name = name;
        this.Surname = surname;
        this.Email = email;
        this.Age = age;
    }

    public void Print()
    {
        Console.WriteLine($"Id: {this.Id}, Name: {this.Name},  Surname: {this.Surname}, Email: {this.Email},  Age: {this.Age}");
    }

    public bool IsAdult()
    {
        if (this.Age >= 18)
            return true;
        else
            return false;
    }

    public bool IsRetired()
    {
        if (this.Age >= 65)
            return true;
        else
            return false;
    }

    public bool IsValidEmail()
    {
        if (this.Email.Contains("@") && this.Email.Contains("."))
            return true;
        else
            return false;
    }
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}