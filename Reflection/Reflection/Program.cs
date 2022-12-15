using Reflection.Models;
using System.Reflection;

public class Program
{
    public static void Main()
    {

        User newUser = new User()
        {
            UserName = "Nigar",
            Email = "tu201906017@code.edu.az"
        };


        static void PrintValue(object obj,params object[] parameters)
        {
            Type type = obj.GetType();
            MethodInfo methodInfo = type.GetMethod("GetValue");
            Console.WriteLine(methodInfo.Invoke(obj, parameters));
        }

        PrintValue(newUser,"Email");
        Console.WriteLine("Username: " + newUser.GetValue("UserName") + "\nEmail: " + newUser.GetValue("Email"));
    }

}




