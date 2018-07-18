using Notificator;
using Services.Services;
using Unity;
using Unity.Lifetime;

namespace Services {
    public static class UnityConfig {
        public static void RegisterTypes(IUnityContainer container) {
            container.RegisterType<IFriendsService, FriendsService>(new SingletonLifetimeManager());
            container.RegisterType<Scheduler>(new SingletonLifetimeManager());
            container.RegisterType<ISmsNotifyer, SmsNotifyer>(new SingletonLifetimeManager());
            container.RegisterType<IConfigService, ConfigService>(new SingletonLifetimeManager());

            DAL.UnityConfig.RegisterTypes(container);
        }
    }
}
