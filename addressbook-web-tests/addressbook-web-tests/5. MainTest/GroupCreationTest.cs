using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressboolTests
{
    [TestFixture]
    class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreationTests()
        {
            navigationHelper.GoToHomePage();
            loginHelper.Login(new AccountData ("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.InitNewGroup();
            GroupData group = new GroupData("aaa");
            group.Header = "ddd";
            group.Footer = "fff";
            FillTheFields(group);
            groupHelper.Submit();
            groupHelper.ReturnToGroupPage();
            
        }
    }
}
