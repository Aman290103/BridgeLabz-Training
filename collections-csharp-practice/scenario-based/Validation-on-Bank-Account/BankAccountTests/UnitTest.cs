using NUnit.Framework;
using System;
using NUnit.Framework.Legacy;  

using Validation_on_Bank_Account;

namespace BankAccountTests
{
      [TestFixture]
      public class UnitTest
      {
            [SetUp]     
            public void Setup()
            {}
            

            [Test]
            public void Test_Deposit_ValidAmount()
            {     
                  //Arrange
                  Program account = new Program(1000);
                  //Act
                  account.Deposit(500);
                  //Assert
                  ClassicAssert.AreEqual(1500, account.Balance);

            }
            [Test]
            public void Test_Deposit_NegativeAmount()
            {
                  Program account = new Program(1000);
                  Assert.Throws<Exception>(() => account.Deposit(-500));
            }
            [Test]
            public void Test_Withdraw_ValidAmount()
            {
                  Program account = new Program(1000);
                  account.Withdraw(500);
                  ClassicAssert.AreEqual(500,account.Balance);
            }
            [Test]
            public void Test_Withdraw_InsufficientFunds()
            {
                 Program account = new Program(1000);
                 Assert.Throws<Exception>(() => account.Withdraw(1500)); 
            }
      }     
}