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
    public bool TryLogin(string username, string password)
    {
        if (username == "Ingio.Montoya" || username == "Princess.Buttercup" && password == "goodpassword") {
            return true;
        }else if (username == "Ingio.Montoya" || username == "Princess.Buttercup" && password == "badpassword")
        {
            return false;
        }
        return false;
    }
    public void Login(string username, string password)
    {
        if (!TryLogin(username, password))
        {
            throw new InvalidOperationException("Your login is not valid.");
        }
    }

    public bool TryConvert(string number, out int? result)
    {
        if(number == "one")
        {
            result = 1;
            return true;
        }
        else
        {
            result = null;
            return false;
        }
    }
}
