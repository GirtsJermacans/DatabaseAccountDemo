using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccount
{
    class UserPrivileges
    {
        // ATTRIBUTES
        private Database dataA;

        // CONSTRUCTOR
        public UserPrivileges(Database data)
        {
            dataA = data;
        }
        // OPERATIONS
        public bool SearchAccount(string name)
        {
            return dataA.SearchAccountFromList(name);
        }
    }
}
