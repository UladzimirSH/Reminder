using System.ComponentModel.DataAnnotations;

namespace Domain.Entities {
    public class User : EntityBase {

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Password { get; set; }
        
        public int PhoneNumber { get; set; }
    }
}
