using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccount
{
    class AdminPrivileges
    {
        // ATTRIBUTES
        private Database data;
        string username = "admin"; // testing log in details
        string password = "test";

        // CONSTRUCTOR
        public AdminPrivileges(Database dataB)
        {
            data = dataB;
        }
        // OPERATIONS
        public bool SearchAccount(string name)
        {
            return data.SearchAccountFromList(name);
        }

        public void AddAccount(string name)
        {
            data.AddAccount(name);
        }

        public void RemoveAccount(string name)
        {
            data.RemoveAccount(name);
        }

        public void ChangeName(string oldName, string newName)
        {
            data.ChangeName(oldName, newName);
        }

        public bool CheckUsername(string input)
        {
            return username == input;
        }

        public bool CheckPassword(string input)
        {
            return password == input;
        }
    }
}
