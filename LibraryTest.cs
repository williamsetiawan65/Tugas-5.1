using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class LibraryTest
    {
        private Day day;
        private User user;

        [SetUp]
        public void Init()
        {
            day = new Day();
            user = new User();
        }
        [Test]
        public void DayTest()
        {
            Assert.AreEqual("Selasa", day.NameOfDay(2));
        }
        [Test]
        public void UserTest()
        {
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
        }
    }
}
