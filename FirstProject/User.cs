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
    
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}