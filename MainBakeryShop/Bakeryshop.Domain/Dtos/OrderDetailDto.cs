using Bakeryshop.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Domain.Dtos
{
    public class OrderDetailDto
    {
        [Display(Name = "شناسه")]
        public long Id { get; set; }

        [Display(Name = "شناسه سفارش")]
        public long OrderId { get; set; }

        [Display(Name = "شناسه نوع نان")]
        public long TypeBreadId { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public decimal Price { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(4, ErrorMessage = ErrorReource.MaxLength)]
        public int Amount { get; set; }

        [Display(Name = "تعداد سفارش")]
        public int DeliveryAmount { get; set; }
    }
}
