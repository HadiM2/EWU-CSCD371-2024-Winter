namespace ClassDemo;

public class Program //internal class Program: Internal is an acess modifier, means you can only acess with this module
{
    public static void Main(string[] args)
    {
        // F12 to go to method, Ctrl to "go back"
        Console.WriteLine()
        Console.WriteLine("Hello, World!");
        console.WriteLine("Meow");
        // Everything is an object and everything is a type in C#
        1.toString();
        "1".getType();
        Console.WriteLine(1.GetType().ToString());
        Console.WriteLine("Hello my name is Hadi");
    }
    //public void Login(string username, string password)
    //{
    //    throw new NotImplementedException();
    //}
    public bool Login(string username, string password)
    {
        if (username == "Ingio.Montoya" && password == "goodpassword") {
            return true;
        }
    }
}
