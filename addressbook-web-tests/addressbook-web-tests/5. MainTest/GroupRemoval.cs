using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Login(new AccountData("admin", "secret"));
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Groups.SelectGroup(2);
            applicationManager.Groups.RemoveGroup();
            applicationManager.Groups.ReturnToGroupPage();
        }        
    }
}

