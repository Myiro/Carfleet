 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carfleet
{
    public class Entreprise
    {
        private string _name;
        private string _address;
        private string _NPA;
        private string _phoneNumber;
        private string _email;
        private List<Car> _cars;

        public Entreprise(string name, string address, string NPA, string phoneNumber, string email, List<Car> cars = null)
        {
            _name = name;
            _address = address;
            _NPA = NPA;
            _phoneNumber = phoneNumber;
            _email = email;
            _cars = cars;
        }


        public int DistanceAverageByDriver()
        {
            if (_cars != null)
            {
                int result = 0;//TODO Variables should be declared as locally as possible.
                int count = 0;
                foreach (var car in _cars)
                {
                    result += car.OdometerCurrentValue;
                    count++;
                }
                result = result / count;

                return result;
            }
            return 0;//TODO refactor proposition           
        }

        public List<string> GetDriversEmail()
        {
            List<string> result = new List<string>();

            foreach (Car car in _cars)
            {
                Driver driver = car.Driver;

                result.Add(driver.EmailAddress);
            }

            return result;
        }
    }
}
