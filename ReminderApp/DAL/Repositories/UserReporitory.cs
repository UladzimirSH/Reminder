using Domain.Contexts;
using Domain.Entities;

namespace DAL.Repositories {    
    public class UserReporitory : Repository<Models.User>, IUserRepository {
        public UserReporitory() : base(new MainContext()) {
        }

        public new void Add(Models.User user) {

            var userModel = new User();
            userModel.Email = user.Email;

            Context.Set<User>().Add(userModel);
        }

        public void Commit() {
            Context.SaveChanges();
        }
    }
}
