using System.Collections.Generic;
using Models;

namespace DAL.Repositories.Declarations {
    public interface IFriendRepository : IRepository<FriendModel> {
        List<FriendModel> GetFeastFriends();
    }
}
