using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksOrderDetail
    {
        public long Id { get; set; }
        public long OrderId { get; set; }
        public long TypeBreadId { get; set; } 
        public decimal Price { get; set; } 
        public int Amount { get; set; } 
        public int DeliveryAmount { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }

        public virtual bksOrder Order { get; set; } = null!;
        public virtual bksTypeBread TypeBread { get; set; } = null!;
    }
}
