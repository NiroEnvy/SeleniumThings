using System;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Threading;
using NUnit.Framework;
using TestProject1.Models;

namespace TestProject1.Tests
{
    [TestFixture]
    public class Test : TestBase
    {
        [Test]
        public void Login()
        {
            App.Navigation.OpenHomePage();
            App.Auth.Login(new AccountData("y_sanek@bk.ru", "42544321cawa"));
        }

        [Test]
        public void SendMail()
        {
            Login();
            Thread.Sleep(5000);
            App.Mail.SendMail(new MailData("kostan-sasha@bk.ru", "bruh"));
        }

        [Test]
        
        public void EditLastDraftTheme()
        {
            Login();
            Thread.Sleep(5000);
            App.Mail.EditLast();
        }
    }
}