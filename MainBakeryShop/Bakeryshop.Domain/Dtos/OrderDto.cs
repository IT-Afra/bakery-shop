using Bakeryshop.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakeryshop.Domain.Dtos
{
    public class OrderDto
    {
        [Display(Name = "شناسه")]
        public long Id { get; set; }

        [Display(Name = "شناسه کاربر")]
        public long UserId { get; set; }

        [Display(Name = "شناسه زمانبندی")]
        public long SchaduleId { get; set; }

        [Display(Name = "تاریخ ثبت به حروف")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(21, ErrorMessage = ErrorReource.MaxLength)]
        public string RegisterDateTime { get; set; } = null!;

        [Display(Name = "تاریخ ثبت به عدد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(8, ErrorMessage = ErrorReource.MaxLength)]
        public long RegisterDateTimeL { get; set; }

        [Display(Name = "تاریخ ارسال به حروف")]
        public string? DeliveryDateTime { get; set; }


        [Display(Name = "تاریخ ارسال به عدد")]
        public long? DeliveryDateTimeL { get; set; }

        [Display(Name = "قیمت کل")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public decimal TotalPrice { get; set; }

    }
}
