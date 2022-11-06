using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class UserClaimCategory:IEntity
    {
       

        public int Id { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }


        public int ClaimCategoryId { get; set; }

        public virtual ClaimCategory ClaimCategory { get; set; }
    }
}
