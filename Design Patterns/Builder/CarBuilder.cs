using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car car;

        public new void reset()
        {
            car = new Car();
        }
        public new void setEngine(string engine)
        {
            car.engine = engine;
        }
        public new void setDoors(int doors)
        {
            car.doors = doors;
        }
        public new void setSeats(int seats)
        {
            car.seats = seats;
        }
        public new Car getResult()
        {
            Car returnCar = car;
            reset();
            return returnCar;
        }
    }
}
