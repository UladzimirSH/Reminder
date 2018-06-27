using System;

namespace Models {
    public class Friend : ModelBase {
        
        public int UserId { get; set; }

        public User User { get; set; }
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Note { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateOfWedding { get; set; }

        public bool IsNotify { get; set; }
    }
}
