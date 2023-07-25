using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class bksTypeBread
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhotoGuid { get; set; } = null!;
        public bool IsActive { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }


    }
}
