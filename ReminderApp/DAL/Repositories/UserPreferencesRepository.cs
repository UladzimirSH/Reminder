using Domain.Entities;
using System.Data.Entity;
using DAL.Repositories.Declarations;

namespace DAL.Repositories {
    public class UserPreferencesRepository: Repository<UserPreferences>, IUserPreferencesRepository {
        public UserPreferencesRepository(DbContext context) : base(context)
        {
        }
    }
}
