using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Technologies_Scheduler.Models
{
    public class Event
    {
        public int ID { get; set; }
        public string VenueID { get; set; }
        public string EventName { get; set; }
        public int NumStaffNeeded { get; set; }
        public DateTime EventStart { get; set; }
        public DateTime EventEnd { get; set; }

        public virtual Venue Venue { get; set; }
        public virtual ICollection<Venue> Venues { get; set; }
    }
}
