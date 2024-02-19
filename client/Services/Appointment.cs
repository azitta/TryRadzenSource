using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TryBlazor
{
    [Table("Appointments")]
    public partial class Appointment
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string ContentText { get; set; } = string.Empty;
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }

        public Appointment()
        {
            ID = Guid.NewGuid();
        }
    }
}
