using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class UserActivity
    {
        public int UserActivityId { get; set; }

        public virtual User User { get; set; }

        public int UserId { get; set; }

        public int ActivityId { get; set; }
        public virtual Activity Activity { get; set; }


    }
}
