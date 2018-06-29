using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
    public class FriendsRepository : Repository<FriendModel, Friend>, IFriendRepository {
        public FriendsRepository(IMapper<FriendModel, Friend> mapper) : base(mapper) {
        }
    }
}
