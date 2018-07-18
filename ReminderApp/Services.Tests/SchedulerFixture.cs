using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Models;
using Moq;
using Notificator;
using NUnit.Framework;
using Services.Services;

namespace Services.Tests {
    [TestFixture]
    public class SchedulerFixture
    {

        private Mock<IConfigService> _configServiceMock;
        private Mock<IFriendsService> _friendsServiceMock;
        private Mock<ISmsNotifyer> _smsNotifyerMock;

        private TestableScheduler _scheduler;

        [SetUp]
        public void SetUp() {
            _configServiceMock = new Mock<IConfigService>();
            _friendsServiceMock = new Mock<IFriendsService>();
            _smsNotifyerMock = new Mock<ISmsNotifyer>();

            InitializeScheduler();
        }

        private void InitializeScheduler() {
            _scheduler = new TestableScheduler(_friendsServiceMock.Object, _smsNotifyerMock.Object, _configServiceMock.Object);
        }

        [Test]
        public void Run_NoTimeToSendNotifications_NoNotificationWillBeSent() {
            _scheduler.IsSendNotifications = false;

            _scheduler.Run();

            _friendsServiceMock.Verify(f => f.GetAllFriends(), Times.Never);
        }

        [Test]
        public void Run_FriendsIsEmpty_NoNotificationWillBeSent() {                        
            _friendsServiceMock.Setup(f => f.GetAllFriends()).Returns(new List<FriendModel>());

            _scheduler.Run();

            _friendsServiceMock.Verify(f => f.GetAllFriends(), Times.Once);
            _smsNotifyerMock.Verify(s => s.NotifyByPhoneNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }

        [Test]
        public void Run_NoFriendHasAnyBirthday_NoNotificationWillBeSent() {
            _scheduler.Run();

            
            _friendsServiceMock.Verify(f => f.GetAllFriends(), Times.Once);
            _smsNotifyerMock.Verify(s => s.NotifyByPhoneNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }

        //[Test]
        //public void Run_NoFriendHasAnyBirthday_NoNotificationWillBeSent() {
        //    _scheduler.Run();
        //    _friendsServiceMock.Verify(f => f.GetAllFriends(), Times.Once);
        //    _smsNotifyerMock.Verify(s => s.NotifyByPhoneNumber(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        //}
    }
}
