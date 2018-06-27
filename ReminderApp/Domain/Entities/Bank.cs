using System.ComponentModel.DataAnnotations;

namespace Domain.Entities {
    public class Bank : EntityBase {        
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
    }
}
