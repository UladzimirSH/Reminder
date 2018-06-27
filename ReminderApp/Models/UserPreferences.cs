namespace Models {
    public class UserPreferences : ModelBase {

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int HourOfNotification { get; set; }

        public bool IsPhoneNotificationEnabled { get; set; }

        public bool IsEmailNotificationEnabled { get; set; }
    }
}
