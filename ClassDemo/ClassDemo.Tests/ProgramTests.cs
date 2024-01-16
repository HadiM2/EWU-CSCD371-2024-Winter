namespace ClassDemo.Tests;

public class ProgramTests
{
    Program _Program;

    //Runs each time before test
    public ProgramTests()
    {
        Cleanup();
        _Program = TestIntialize();
        File file = new File();
    }
    int _InstanceCount = 0;

    private static Program TestIntialize()
    {
        return new Program();
    }

    [Fact]
    public void Login_InigoMontoyaWithGoodPassword_SuccessfulLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Ingio.Montoya";
        string password = "goodpassword";
        Assert.True(_Program.Login(username, password));
        _InstanceCount++;

        //Program.Main();
        //program.Login(username: "Ingio.Montoya", password: "password");
    }

    [Fact]
    public void Login_InigoMontoyaWithGoodPassword_FailedLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Ingio.Montoya";
        string password = "badpassword";
        Assert.False(_Program.Login(username, password));
        _InstanceCount++;
        //program.Login(username: "Ingio.Montoya", password: "password");

    }
    //[Fact]
    //public void Login_

}
