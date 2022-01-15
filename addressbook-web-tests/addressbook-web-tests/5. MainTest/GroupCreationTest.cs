using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreationTests()
        {
            applicationManager.Navigator.GoToHomePage();
            applicationManager.Auth.Login(new AccountData ("admin", "secret"));
            applicationManager.Navigator.GoToGroupsPage();
            applicationManager.Groups.InitNewGroup();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            applicationManager.Groups.FillTheFields(group);
            applicationManager.Groups.Submit();
            applicationManager.Groups.ReturnToGroupPage();
            
        }
    }
}
