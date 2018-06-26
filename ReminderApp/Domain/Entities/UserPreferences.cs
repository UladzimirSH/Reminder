namespace Domain.Entities {
    public class UserPreferences {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HourOfNotification { get; set; }
        public bool IsPhoneNotificationEnabled { get; set; }
        public bool IsEmailNotificationEnabled { get; set; }
    }
}
