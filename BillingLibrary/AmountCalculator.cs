using DataBaseLibrary;
using System.Threading.Tasks;

namespace BillingLibrary
{
    public class AmountCalculator
    {
        private readonly IUserDataAccess _userDataAccess;

        public AmountCalculator(IUserDataAccess userDataAccess)
        {
            _userDataAccess = userDataAccess;
        }

        public async Task<decimal> CalculateTotalBillById(int id)
        {
            decimal billAmount;

            string userName = await _userDataAccess.GetUserNameByIdAsync(id);

            if (userName == "Mariliis")
            {
                billAmount = 100.0m;
            }
            else
            {
                billAmount = 25.0m;
            }

            return billAmount;
        }
    }
}
