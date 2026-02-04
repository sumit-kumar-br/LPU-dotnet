using System;
using NUnit.Framework;

public class Program
{
    public decimal Balance { get; private set; }

    public Program(decimal initialBalance)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount < 0)
        {
            throw new Exception("Deposit amount cannot be negative");
        }

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount > Balance)
        {
            throw new Exception("Insufficient funds.");
        }

        Balance -= amount;
    }
}

[TestFixture]
public class UnitTest
{
    [Test]
    public void Test_Deposit_ValidAmount()
    {
        Program account = new Program(1000m);
        account.Deposit(500m);
        Assert.That(account.Balance, Is.EqualTo(1500m));
    }

    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        Program account = new Program(1000m);
        Assert.That(
            Assert.Throws<Exception>(() => account.Deposit(-100m)).Message,
            Is.EqualTo("Deposit amount cannot be negative")
        );
    }

    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        Program account = new Program(800m);
        account.Withdraw(300m);
        Assert.That(account.Balance, Is.EqualTo(500m));
    }

    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        Program account = new Program(200m);
        Assert.That(
            Assert.Throws<Exception>(() => account.Withdraw(400m)).Message,
            Is.EqualTo("Insufficient funds.")
        );
    }
}
