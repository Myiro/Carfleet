using NUnit.Framework;
using Carfleet;
using System;

namespace Testfleet
{
    public class TestCar
    {
        private Car _car = null;
        private string _registration;
        private string _brand;
        private string _model;
        private string _chaissisNumber;
        private int _adometerInitialValue;
        private Driver _driver;
        private int _adometerCurentValue;

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



            _registration = "VD-437843";
            _brand = "porsche";
            _model = "911";
            _chaissisNumber = "213EG563D56";
            _adometerInitialValue = 3000;

            _car = new Car(_registration, _brand, _model, _chaissisNumber, _driver);

        }

        [Test]
        public void Car_Distance_success()
        {
            int actualValue = 0;
            int expectedValue = 100;

            Car car = new Car(_registration, _brand, _model, _chaissisNumber, _driver);

            car.OdometerOldValue = 3000;
            car.OdometerCurrentValue = 3100;

            actualValue = car.Distance;

            Assert.AreEqual(expectedValue, actualValue);
        }


    }
}