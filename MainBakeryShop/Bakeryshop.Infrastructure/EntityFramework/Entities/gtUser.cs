using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Infrastructure.EntityFramework.Entities
{
    public class gtUser
    {
        public long Id { get; set; }
        public string? Title { get; set; } 
        public string? Name { get; set; }
        public string? Family  { get; set; } 
        public bool? IsMale { get; set; }
        public string? BirthDate { get; set; }
        public bool InfoConfirmed { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public bool PhoneNumberConfirmed { get; set; }
        public string? Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string? Password { get; set; }
        public bool LockoutEnabled { get; set; }
        public DateTime? LockoutEnd { get; set; }
        public int AccessFailedCount { get; set; }
        public int NotificationCount { get; set; }
        public int MessageCount { get; set; }
        public string? PhotoGuid { get; set; }
        public bool IsMessageBlocked { get; set; }
        public bool IsActive { get; set; }
        public long? ModifierUser { get; set; }
        public long? ModifierDate { get; set; }

    }
}
