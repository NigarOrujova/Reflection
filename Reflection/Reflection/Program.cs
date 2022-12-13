using Reflection.Models;

User t = new User()
{
    UserName = "Nigar",
    Email = "tu201906017@code.edu.az"
};

Console.WriteLine("Username: " + t.GetValue("UserName") + "\nEmail: " + t.GetValue("Email"));