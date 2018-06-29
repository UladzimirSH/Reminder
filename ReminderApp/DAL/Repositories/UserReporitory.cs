using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {    
    public class UserReporitory : Repository<UserModel, User>, IUserRepository {
        public UserReporitory(IMapper<UserModel, User> mapper) : base(mapper)
        {
        }
    }
}
