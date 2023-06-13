using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksSchaduleDetail
    {
        public long Id { get; set; }
        public long SchaduleId { get; set; }
        public long TypeBreadId { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }  
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }

        public virtual ICollection<bksSchadule> Schadules { get; set; } = null!;
        public virtual ICollection<bksTypeBread> TypeBreads { get; set; } = null!;

    }
}
