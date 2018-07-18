using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using Models;
using Services.Services;

namespace RApp.Controllers {
    public class FriendsController : Controller {

        private readonly IFriendsService _friendsService;
        public FriendsController(IFriendsService friendsService) {
            _friendsService = friendsService;
        }

        public ActionResult Friends() {
            var friends = _friendsService.GetAllFriends().ToList();
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
    }
}