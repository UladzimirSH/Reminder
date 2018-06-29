using System.Data.Entity;
using DAL.Mappers;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;

namespace DAL.Repositories {
    public class UserPreferencesRepository: Repository<UserPreferencesModel, UserPreferences>, IUserPreferencesRepository {
        public UserPreferencesRepository(IMapper<UserPreferencesModel, UserPreferences> mapper) : base(mapper)
        {
        }
    }
}
