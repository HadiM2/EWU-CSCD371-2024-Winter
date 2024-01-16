namespace ClassDemo.Tests;

public class ProgramTests
{
    [Fact]
    public void Login_InigoMontoyaWithGoodPassword_SuccessfulLogin()
    {
        Program program = new Program();
        //program.Login(username: "Ingio.Montoya", password: "password");
        string username = "Ingio.Montoya";
        string password = "goodpassword";
        //Program.Main();
        Assert.True(program.Login(username, password));
    }

    [Fact]
    public void Login_InigoMontoyaWithGoodPassword_FailedLogin()
    {
        Program program = new Program();
        //program.Login(username: "Ingio.Montoya", password: "password");
        string username = "Ingio.Montoya";
        string password = "badpassword";
        Assert.False(program.Login(username, password));

    }

}
