using Microsoft.AspNetCore.Mvc;
using NewTest.DAO;
using NewTest.Models;

namespace NewTest.Controllers
{
    public class LoginController : Controller
    {
        UserDAO userDAO = new UserDAO();
        public LoginController() {
        }
        public IActionResult LoginPage()
        {

            return View();
        }

        public IActionResult RegistrationPage()
        {
            return View("Registration");
        }
        public IActionResult Registration(string password, string userName)
        {
            userDAO.defineNewUser(password, userName);

            List<User> userList = new List<User>();
            userList = userDAO.getList();
            return View("UserList", userList);
        }

        public IActionResult LoginVerification(User user)
        {
            return View();
        }
        
    }
}
