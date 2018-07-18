using Notificator;
using Services.Services;

namespace Services.Tests {
    public class TestableScheduler : Scheduler {
        public TestableScheduler(IFriendsService friendsService, ISmsNotifyer smsNotifyer, IConfigService configService) : base(friendsService, smsNotifyer, configService) {
        }

        public bool IsSendNotifications { get; set; } = true;

        protected override bool IsTimeToSendNotifications() {
            return IsSendNotifications;
        }        
    }
}
