using Entity = Domain.Entities;
using UserModel = Models.UserModel;

namespace DAL.Mappers {
    public class UserMapper : IMapper<UserModel, Entity.User> {
        public Entity.User ToEntity(UserModel model) {
            return new Entity.User {
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber
            };
        }

        public UserModel ToModel(Entity.User entity) {
            return new UserModel {
                Email = entity.Email,
                Password = entity.Password,
                PhoneNumber = entity.PhoneNumber
            };
        }
    }
}
