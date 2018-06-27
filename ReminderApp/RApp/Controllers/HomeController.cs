using System.Web.Mvc;
using DAL.Repositories.Declarations;
using Models;

namespace RApp.Controllers {
    public class HomeController : Controller
    {

        private readonly IUserRepository _userRepository;
        public HomeController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public ActionResult Index() {
            return View();
        }

        

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

           
            _userRepository.Add(new User());
            _userRepository.Commit();

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}