using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksOrder
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long SchaduleId { get; set; }
        public string RegisterDateTime { get; set; } = null!;
        public long RegisterDateTimeL { get; set; }
        public string? DeliveryDateTime { get; set; }
        public long? DeliveryDateTimeL { get; set; }
        public decimal TotalPrice { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }

        public virtual bksSchadule Schadule { get; set; } = null!;
        public virtual gtUser User { get; set; } = null!;
    }
}
