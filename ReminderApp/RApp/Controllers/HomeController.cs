using Models;
using Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace RApp.Controllers {
    public class HomeController : Controller {

        private readonly IFriendsService _friendsService;
        public HomeController(IFriendsService friendsService) {
            _friendsService = friendsService;
        }

        public ActionResult Index() {
            return View();
        }

        public ActionResult Friends() {            
            var friends = _friendsService.GetAllFriends(1).ToList();
            return View(friends);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult SaveFriends([FromBody] FriendModel data) {
            var list = new List<FriendModel> { data };
            _friendsService.AddFriends(list);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

        [System.Web.Mvc.HttpPost]
        public ActionResult DeleteFriend(int friendId) {
            var list = new List<int> { friendId };
            _friendsService.RemoveFriends(list);
            return Json("success", JsonRequestBehavior.AllowGet);
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}