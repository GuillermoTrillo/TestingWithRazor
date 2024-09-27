using NewTest.Models;
using System.Reflection.Emit;
namespace NewTest.DAO
{
    public class UserDAO
    {
        private List<User> Userlist = new List<User>();
        private int recentId = 0;
        public void defineNewUser(string newPassword, string newUserName)
        {
            User newUser = new User();
            defineRecentId();
            newUser.idUser = recentId;
            newUser.userName = newUserName;
            newUser.password = newPassword;

            addNewUserToList(newUser);
        }
        private void defineRecentId()
        {
            if (recentId != 0)
            {
                recentId = recentId + 1;
            }
        }
        private void addNewUserToList(User newUser)
        {
            Userlist.Add(newUser);
        }
        public List<User> getList()
        {
            return Userlist; 
        }
    }
}
