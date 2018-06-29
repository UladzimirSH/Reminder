using DAL.Mappers;
using DAL.Repositories;
using DAL.Repositories.Declarations;
using Domain.Entities;
using Models;
using Unity;

namespace DAL {
    public static class UnityConfig {
        public static void RegisterTypes(IUnityContainer container) {
            container.RegisterType<IUserRepository, UserReporitory>();

            container.RegisterType<IFriendRepository, FriendsRepository>();
            container.RegisterType<IMapper<FriendModel, Friend>, FriendMapper>();
        }
    }
}
