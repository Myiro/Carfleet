using NUnit.Framework;
using Carfleet;
using System.Collections.Generic;

namespace Testfleet
{
    public class TestEntreprise
    {
        private Entreprise _entreprise;
        private string _entName;
        private string _address;
        private string _NPA;
        private string _entPhoneNumber;
        private string _email;
        private List<Car> _cars;

        private Car _car;
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

            _cars = new List<Car>();

            for (int i = 0; i < 10; i++)
            {
                _registration = "VD-437843";
                _brand = "porsche";
                _model = "911";
                _chaissisNumber = "213EG563D56";
                _adometerInitialValue = 3000;
                _adometerCurentValue = 3000;

                _car = new Car(_registration, _brand, _model, _chaissisNumber, _driver, _adometerInitialValue, _adometerCurentValue);

                _cars.Add(_car);
            }
                
            _entName = "Koppa";
            _address = "KoppaLand";
            _NPA = "KoppaCity";
            _entPhoneNumber = "1234567";
            _email = "koppa@koppa.koppa";

            _entreprise = new Entreprise(_entName, _address, _NPA, _entPhoneNumber, _email, _cars);
        }

        [Test]
        public void Car_DistanceAverageByDriver_success()
        {
            int expectedValue = 3000;

            int result = _entreprise.DistanceAverageByDriver();
            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        public void Driver_GetDriverEmail()
        {
            List<string> expectedValue = new List<string>();
            List<string> actualValue = new List<string>();
            string value = "Luca@gatto.ch";
            for (int i = 0; i < 10; i++)
            {
                expectedValue.Add(value);
            }

            actualValue = _entreprise.GetDriversEmail();

            Assert.AreEqual(actualValue, expectedValue);
        }
    }
}