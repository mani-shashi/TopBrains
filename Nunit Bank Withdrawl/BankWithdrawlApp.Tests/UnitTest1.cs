namespace BankWithdrawlApp.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(1000m);

        Assert.AreEqual(
                "Deposit amount cannot be negative",
                Assert.Throws<Exception>(() => account.Deposit(-100m)).Message
        );
    }
}
