namespace ClassDemo.Tests;

public class ProgramTests
{
    Program Program { get; set; };

    //Runs each time before test
    public ProgramTests()
    {
        Cleanup();
        Program = TestIntialize();
        File file = new File();
    }
    int _InstanceCount = 0;

    private static Program TestIntialize()
    {
        return new Program();
    }

    [Fact]
    public void TryLogin_InigoMontoyaWithGoodPassword_SuccessfulLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Ingio.Montoya";
        string password = "goodpassword";
        Assert.True(Program.Login(username, password));
        _InstanceCount++;

        //Program.Main();
        //program.Login(username: "Ingio.Montoya", password: "password");
    }

    [Fact]
    public void TryLogin_InigoMontoyaWithGoodPassword_FailedLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Ingio.Montoya";
        string password = "badpassword";
        Assert.False(Program.Login(username, password));
        _InstanceCount++;
        //program.Login(username: "Ingio.Montoya", password: "password");

    }
    [Fact]
    public void TryLogin_PrincessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Assert.True(Program.Login("Princess.Buttercup", "goodpassword")
    }
    [Fact]
    public void Login_PrinccessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Assert.True(Program.Login(username: "Princess.Buttercup", password: "goodpassword"))
    }

    [Fact]
    public void Login_PrinccessButtercupWithGoodPassword_FailedLogin()
    {
        Assert.Throws<InvalidOperationException>(
            () => Program.Login(username: "Princess.Buttercup", password: "badpassword"))
    }
    [Fact]
    public void Login_PrinccessButtercupWithGoodPasswordTryCatch_FailedLogin()
    {
        try
        {
            Program.Login(username: "Princess.Buttercup", password: "badpassword")
        }
        catch(InvalidOperationException)
        {
            return;
        }
        Assert.Fail("Exception not thrown for bad login")
    }
}
