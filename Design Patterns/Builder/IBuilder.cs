using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    public class IBuilder
    {
        public void reset() { }
        public void setEngine(string engine) { }
        public void setDoors(int doors) { }
        public void setSeats(int seats) { }
        public Car getResult() { return new Car(); }

    }
}
