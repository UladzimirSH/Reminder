using Domain.Entities;
using Models;

namespace DAL.Mappers {
    public class FriendMapper : IMapper<FriendModel, Friend> {

        public Friend ToEntity(FriendModel model) {
            return new Friend() {
                Id = model.Id,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Note = model.Note,
                DateOfBirth = model.DateOfBirth,
                DateOfWedding = model.DateOfWedding,
                IsNotify = model.IsNotify
            };
        }

        public FriendModel ToModel(Friend entity) {
            return new FriendModel() {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Note = entity.Note,
                DateOfBirth = entity.DateOfBirth,
                IsNotify = entity.IsNotify
            };
        }
    }
}
