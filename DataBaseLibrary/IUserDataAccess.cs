using System.Threading.Tasks;

namespace DataBaseLibrary
{
    public interface IUserDataAccess
    {
        bool IsValidForAsync { get; set; }

        string GetUserNameById(int id);

        Task<string> GetUserNameByIdAsync(int id);
    }
}
