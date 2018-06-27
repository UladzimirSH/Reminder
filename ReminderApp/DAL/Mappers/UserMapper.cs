using Entity = Domain.Entities;
using User = Models.User;

namespace DAL.Mappers {
    public class UserMapper : IMapper<User, Entity.User> {
        public Entity.User ToModel(User model) {
            return new Entity.User {
                Email = model.Email,
                Password = model.Password,
                PhoneNumber = model.PhoneNumber
            };
        }

        public User ToEntity(Entity.User entity) {
            return new User {
                Email = entity.Email,
                Password = entity.Password,
                PhoneNumber = entity.PhoneNumber
            };
        }
    }
}
