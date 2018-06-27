using DAL.Repositories.Declarations;
using Domain.Contexts;
using Models;

namespace DAL.Repositories {    
    public class UserReporitory : Repository<User>, IUserRepository {
        public UserReporitory() : base(new MainContext()) {
        }      
    }
}
