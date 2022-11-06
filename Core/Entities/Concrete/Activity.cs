using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public DateTime ActivityTime { get; set; }
        public int ActivityTypeId { get; set; }
        public ActivityType ActivityType { get; set; }
    }
}
