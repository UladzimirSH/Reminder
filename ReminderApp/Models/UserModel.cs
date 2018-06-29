namespace Models {
    public class UserModel : ModelBase {
        public string Email { get; set; }

        public string Password { get; set; }

        public int PhoneNumber { get; set; }

        public UserPreferencesModel Preferences { get; set; }
    }
}
