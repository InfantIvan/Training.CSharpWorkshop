﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Training.CSharpWorkshop.Tests
{
    [TestClass]
    public class ProgramTests
    {
        [Ignore]
        [TestMethod]
        public void IgnoreTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetRoleMessageForAdminTest()
        {
            // Arrange
            var userName = "Andrew";
            var expected = "Role: Admin.";

            // Act
            var actual = Program.GetRoleMessage(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetRoleMessageForGuestTest()
        {
            // Arrange
            var userName = "Dave";
            var expected = "Role: Guest.";

            // Act
            var actual = Program.GetRoleMessage(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetRoleMessageForNoneTest()
        {
            // Arrange
            var userName = "Don";
            var expected = "Role: None.";

            // Act
            var actual = Program.GetRoleMessage(userName);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
