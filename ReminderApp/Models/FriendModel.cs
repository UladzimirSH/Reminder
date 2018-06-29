using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Models {
    public class FriendModel : ModelBase, ICloneable {

        public FriendModel() {
            DateOfBirth = DateTime.Now;
            DateOfWedding = DateTime.Now;
        }
        
        public int UserId { get; set; }

        public UserModel User { get; set; }
        
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Note")]
        public string Note { get; set; }

        [DisplayName("Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [DisplayName("Date of Wedding")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime DateOfWedding { get; set; }

        public bool IsNotify { get; set; }
        public object Clone() {
            return this.MemberwiseClone();
        }
    }
}
