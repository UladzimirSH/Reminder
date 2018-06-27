using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities {
    public class UserPreferences : EntityBase {
        
        [Required]
        [ForeignKey(nameof(User))]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int HourOfNotification { get; set; }

        [Required]
        public bool IsPhoneNotificationEnabled { get; set; }

        [Required]
        public bool IsEmailNotificationEnabled { get; set; }
    }
}
