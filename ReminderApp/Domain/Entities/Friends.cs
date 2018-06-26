using System;

namespace Domain.Entities {
    public class Friends {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Note { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfWedding { get; set; }
        public bool IsNotify { get; set; }
    }
}
