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


        public int DistanceAverageByDriver
        {
            get
            {
                int result = 0;
                int count = 0;
                if (_cars != null)
                {
                    foreach (var car in _cars)
                    {
                        result = result + car.OdometerCurrentValue;
                        count++;
                    }
                }
                else
                {
                    return 0;
                }
                

                result = result / count;

                return result;
            }
            
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
