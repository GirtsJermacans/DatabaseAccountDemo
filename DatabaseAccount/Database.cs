using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccount
{
    class Database
    {
        // ATTRIBUTES
        string name = "Batman"; // for testing purposes
        List<string> accounts = new List<string>();
        // CONSTRUCTOR

        // OPERATIONS
        public bool SearchAccount(string searchName) // for testing purposes
        {
            return name == searchName;
        }

        public bool SearchAccountFromList(string searchName)
        {
            bool found = false;
            foreach (string name in accounts)
            {
                if (name == searchName)
                    found = true;
            }
            return found;
        }

        public void ChangeName(string oldName, string newName)
        {
            int index = accounts.IndexOf(oldName);
            if (index >= 0)
                accounts[index] = newName;
        }

        public void AddAccount(string name)
        {
            accounts.Add(name);
        }

        public void RemoveAccount(string name)
        {
            accounts.Remove(name);
        }
        
    }
}
