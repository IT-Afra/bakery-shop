using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksSchadule
    {
        public bksSchadule()
        {
            SchaduleDetails = new HashSet<bksSchaduleDetail>();
        }

        public long Id { get; set; }
        public string SchaduleDate { get; set; } = null!;
        public long SchaduleDateL { get; set; }
        public string SchaduleTime { get; set; } = null!;
        public int SchaduleTimeL { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }

        public virtual ICollection<bksSchaduleDetail> SchaduleDetails { get; set; }
    }
}
