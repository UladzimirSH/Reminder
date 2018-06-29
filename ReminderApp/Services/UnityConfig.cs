using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Mappers;
using DAL.Repositories;
using DAL.Repositories.Declarations;
using Models;
using Services.Services;
using Unity;

namespace Services {
    public static class UnityConfig {
        public static void RegisterTypes(IUnityContainer container) {
            container.RegisterType<IFriendsService, FriendsService>();

            DAL.UnityConfig.RegisterTypes(container);
        }
    }
}
