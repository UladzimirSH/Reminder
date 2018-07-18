using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
    public class FriendsRepository : Repository<FriendModel, Friend>, IFriendRepository {
        public FriendsRepository(IMapper<FriendModel, Friend> mapper) : base(mapper) {
        }

        public List<FriendModel> GetFeastFriends() {
            var result = Context.Set<Friend>().Where(r => r.DateOfBirth.DayOfYear == DateTime.UtcNow.DayOfYear
                                                          || r.DateOfBirth.DayOfYear - 1 == DateTime.UtcNow.DayOfYear
                                                          || (r.DateOfWedding.HasValue && (r.DateOfWedding.Value.DayOfYear == DateTime.UtcNow.DayOfYear
                                                          || r.DateOfWedding.Value.DayOfYear - 1 == DateTime.UtcNow.DayOfYear))).ToList();
            return result.Select(r => _mapper.ToModel(r)).ToList();
        }
    }
}
