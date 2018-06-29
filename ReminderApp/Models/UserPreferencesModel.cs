namespace Models {
    public class UserPreferencesModel : ModelBase {

        public int UserId { get; set; }
        public virtual UserModel User { get; set; }

        public int HourOfNotification { get; set; }

        public bool IsPhoneNotificationEnabled { get; set; }

        public bool IsEmailNotificationEnabled { get; set; }
    }
}
