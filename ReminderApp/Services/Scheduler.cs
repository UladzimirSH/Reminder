using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using Models;
using Notificator;
using Services.Services;
using Timer = System.Timers.Timer;

namespace Services {
    public class Scheduler {
        private readonly IFriendsService _friendsService;
        private readonly ISmsNotifyer _smsNotifyer;
        private readonly IConfigService _configService;

        private int _secondsInHour = 6;

        public Scheduler(IFriendsService friendsService, ISmsNotifyer smsNotifyer, IConfigService configService) {
            _friendsService = friendsService;
            _smsNotifyer = smsNotifyer;
            _configService = configService;            
        }
     
        protected virtual bool IsTimeToSendNotifications() => DateTime.UtcNow.Hour == _configService.GetUtcRecieverHour();
        protected virtual bool IsBirthdayToday(int dayOfYear) => dayOfYear == DateTime.UtcNow.DayOfYear;
        protected virtual bool IsBirthdayTomorrow(int dayOfYear) => dayOfYear -1 == DateTime.UtcNow.DayOfYear;

        public void Run() {
            var timer = new Timer(_secondsInHour);
            timer.Elapsed += TimerOnElapsed;
            timer.Enabled = true;
        }


        private void TimerOnElapsed(object sender, ElapsedEventArgs e) {           
            if (IsTimeToSendNotifications()) {
                CheckFriends();
            }
        }        

        private void CheckFriends() {         
            var friends = _friendsService.GetAllFriends();
            if (friends == null || !friends.Any()) {
                return;
            }

            var comingBirthdays = friends.Where(f => IsBirthdayTomorrow(f.DateOfBirth.DayOfYear));
            var todayBirthdays = friends.Where(f => IsBirthdayToday(f.DateOfBirth.DayOfYear));

            string comingMsg = GetBirthMsgForFriends("Tomorrow's Birthdays:", comingBirthdays);
            string todayMsg = GetBirthMsgForFriends("Today's Birthdays:", todayBirthdays);
            if (string.IsNullOrEmpty(comingMsg) && string.IsNullOrEmpty(todayMsg)) {
                return;
            }
            _smsNotifyer.NotifyByPhoneNumber(_configService.GetPhoneNumber(), $"{comingMsg} {todayMsg}");
        }

        private string GetBirthMsgForFriends(string preface, IEnumerable<FriendModel> friends) {
            if (friends == null || !friends.Any()) {
                return string.Empty;
            }

            return string.Concat(preface, string.Join(",", friends.Select(f => $"{f.FirstName} {f.LastName}")));
        }
    }
}
