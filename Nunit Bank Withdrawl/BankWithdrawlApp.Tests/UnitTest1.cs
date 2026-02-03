namespace BankWithdrawlApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(2000);
        account.Deposit(800);
        
        Assert.AreEqual(2800,account.Balance);
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(1000);

        Exception e = Assert.Throws<Exception>(() => account.Deposit(-100));

        Assert.AreEqual("Balance can't be zero or negative.", e.Message);
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(200);

        Exception e = Assert.Throws<Exception>(() => account.Withdraw(800));

        Assert.AreEqual("Insufficent balance in the account.", e.Message);
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(2000);
        account.Withdraw(650);

        Assert.AreEqual(1350, account.Balance);
    }
}
