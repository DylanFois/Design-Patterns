using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class ProgramSingleton
    {
        Database db1 = Database.getInstance();
        Database db2 = Database.getInstance(); // Both these Databases point to the same instance
    }
}
