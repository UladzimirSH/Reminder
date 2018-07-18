using Models;
using System.Collections.Generic;

namespace Services.Services {
    public interface IFriendsService {
        IEnumerable<FriendModel> GetAllFriends();
        void RemoveFriends(List<int> ids);
        void AddFriends(List<FriendModel> friends);
        List<FriendModel> GetFeastFriends();
    }
}
