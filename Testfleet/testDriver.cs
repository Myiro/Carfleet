using NUnit.Framework;
using Carfleet;
using System;

namespace Testfleet
{
    public class TestDriver
    {
        private Driver _driver;
        private string _name;
        private string _firstname;
        private string _city;
        private string _phoneNumber;
        private string _emailAddress;
        private string _language;

        [SetUp]
        public void Setup()
        {
            _name = "Gatto";
            _firstname = "Luca";
            _city = "Yverdon";
            _phoneNumber = "078 972 27 84";
            _emailAddress = "Luca@gatto.ch";
            _language = "italien";

            _driver = new Driver(_name, _firstname, _city, _phoneNumber, _emailAddress, _language);

        }

        [Test]
        public void Driver_AddDriver_Success()
        {
            string expectedValue = "Luca";
            Driver driver = new Driver(_name, _firstname, _city, _phoneNumber, _emailAddress, _language);

            Assert.AreEqual(expectedValue, driver.Firstname);
        }
    }
}