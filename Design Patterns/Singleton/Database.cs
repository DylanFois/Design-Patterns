using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton
{
    public class Database
    {
        private static Database _database;

        private Database() // Private constructor so that other classes can't call it and create new instances
        {
            // Code that would connect the database instance to the database
        }

        public static Database getInstance() // If there is not already a database instance, then create one and return it.
        {                                    // Otherwise, if there is already an instance then return the instance that is already there.
            if( _database == null)
            {
                _database = new Database();
                Console.WriteLine(_database);
            }

            return _database;
        }

        public String Query(String sql)
        {
            Console.WriteLine(_database);
            return "hamburger";
        }
    }
}
