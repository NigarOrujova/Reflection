using Reflection.Models;

User newUser = new User()
{
    UserName = "Nigar",
    Email = "tu201906017@code.edu.az"
};

Console.WriteLine("Username: " + newUser.GetValue("UserName") + "\nEmail: " + newUser.GetValue("Email"));