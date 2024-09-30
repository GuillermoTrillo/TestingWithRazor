using NewTest.Models;
using System.Reflection.Emit;
namespace NewTest.DAO
{
    public class UserDAO
    {
        private List<User> Userlist = new List<User>();
        private int recentId;
        public void defineNewUser(string newPassword, string newUserName)
        {
            defineRecentId();
            Console.WriteLine(Userlist);
            User newUser = new User();
            newUser.idUser = recentId;
            newUser.userName = newUserName;
            newUser.password = newPassword;

            addNewUserToList(newUser);
        }
        private void defineRecentId()
        {
            recentId++;
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
