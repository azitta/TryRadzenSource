using System;
using System.ComponentModel.DataAnnotations;

namespace TryBlazor
{
    public class Appointment
    {
        public long ID { get; set; }
        public string Text { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

    }
}
