using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technologies_Scheduler.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool FullTime { get; set; }
        public virtual ICollection<Event> Events { get; set; }
    }
}
