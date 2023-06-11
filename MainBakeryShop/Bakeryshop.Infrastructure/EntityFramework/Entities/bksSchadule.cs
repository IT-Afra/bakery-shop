using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksSchadule
    {
        public long Id { get; set; }
        public string OrderDate { get; set; } = null!;
        public long OrderDateL { get; set; }
        public string OrderTime { get; set; } = null!;
        public int OrderTimel { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }
    }
}
