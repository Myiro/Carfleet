using System;

namespace Carfleet
{
    public class Car
    {

        private string _registration;
        private string _brand;
        private string _model;
        private string _chassisNumber;
        private Driver _driver;
        private int _odometerCurrentValue;
        private int _odometerOldValue;

        public Car(string registration, string brand, string model, string chassisNumber, Driver driver, int odometerOldValue = 0, int odometerCurrentValue = 0)
        {
            _registration = registration;
            _brand = brand;
            _model = model;
            _chassisNumber = chassisNumber;
            _driver = driver;
            _odometerOldValue = odometerOldValue;
            _odometerCurrentValue = odometerCurrentValue;
        }

        public int OdometerCurrentValue
        {
            set
            {
                _odometerCurrentValue = value;
            }
            get
            {
                return _odometerCurrentValue;
            }
        }

        public int OdometerOldValue
        {
            set
            {
                _odometerOldValue = value;
            }
            get
            {
                return _odometerOldValue;
            }
        }

        public int Distance
        {
            get
            {
                return _odometerCurrentValue - _odometerOldValue;
            }
        }

        public Driver Driver
        {
            set
            {
                _driver = value;
            }
            get
            {
                return _driver;
            }
        }
    }
}
