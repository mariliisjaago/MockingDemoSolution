using System;
using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public class UserDataAccess : IUserDataAccess
    {
        public bool IsValidForAsync { get; set; }

        public string GetUserNameById(int id)
        {
            // This code goes to the database, finds the given id, and retrieves
            // that user's name to us.

            // Simulating some work:
            if (id == 1)
            {
                return "Mariliis";
            }
            else
            {
                return "Sarah";
            }
        }

        public Task<string> GetUserNameByIdAsync(int id)
        {
            // Get user's name from the database, asynchronously.

            if (IsValidForAsync == true)
            {
                var name = Task.Run(() => GetUserNameById(1));

                return name;
            }
            else
            {
                throw new Exception("Using async method was not valid.");
            }
        }


    }
}
