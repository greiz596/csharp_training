using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace WebAddressbookTests
{
    [TestFixture]
     class ContactCreationTest : TestBase
    {
        [Test]
        public void CreateContact()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Contacts.InitNewContact();
            ContactData contact = new ContactData("Tri", "Dva", "Raz");
            contact.Nickname = "ti";
            contact.Company = "pi";
            contact.Home = "dor";
            applicationManager.Contacts.FillTheFields(contact);
            applicationManager.Contacts.SaveNewContact();
            applicationManager.Navigator.ReturnToHomePage();
        }
    }
}
