using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class Director
    {
        public Car createSportsCar(CarBuilder builder)
        {
            builder.reset();
            builder.setEngine("V8");
            builder.setDoors(2);
            builder.setSeats(2);

            return builder.getResult();
        }

        public Car createSUV(CarBuilder builder)
        {
            builder.reset();
            builder.setEngine("V6");
            builder.setDoors(4);
            builder.setSeats(7);

            return builder.getResult();
        }
    }
}
