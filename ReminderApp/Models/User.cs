namespace Models {
    public class User: ModelBase {        
        public string Email { get; set; }

        public string Password { get; set; }

        public int PhoneNumber { get; set; }
    }
}
