using FirstProject;

Console.WriteLine("Enter id for new user");
int userId = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter name for new user");
string userName = Console.ReadLine();

Console.WriteLine("Enter surname for new user");
string userSurname = Console.ReadLine();

Console.WriteLine("Enter email for new user");
string userEmail = Console.ReadLine();

Console.WriteLine("Enter age for new user");
int userAge = Convert.ToInt32(Console.ReadLine());

User user = new User(userId, userName, userSurname, userEmail, userAge);
user.Print();

Console.WriteLine("Is user adult -> " + user.IsAdult());