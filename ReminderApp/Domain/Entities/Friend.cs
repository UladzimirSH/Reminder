using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities {
    public class Friend : EntityBase {

        [Required]        
        public int UserId { get; set; }

        //public virtual User User { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        public DateTime? DateOfWedding { get; set; }

        [Required]
        public bool IsNotify { get; set; }
    }
}
