using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities {
    public class TaskType {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
    }
}
