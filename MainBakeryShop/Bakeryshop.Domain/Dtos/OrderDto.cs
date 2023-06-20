using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class OrderDto
    {

        public OrderDto()
        {
            OrderDetails = new List<OrderDetailDto>();
        }

        [Display(Name = "شناسه")]
        public long? Id { get; set; }

        [Display(Name = "شناسه زمانبندی")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public long? SchaduleId { get; set; }

        [Display(Name = "تاریخ زمانبندی")]
        public string? SchaduleDate { get; set; }

        [Display(Name = "ساعت زمانبندی")]
        public string? SchaduleTime { get; set; }

        [Display(Name = "تاریخ ثبت به حروف")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(21, ErrorMessage = ErrorReource.MaxLength)]
        public string? RegisterDateTime { get; set; } = null!;

        [Display(Name = "تاریخ ارسال به حروف")]
        public string? DeliveryDateTime { get; set; }

        [Display(Name = "قیمت کل")]
        public decimal? TotalPrice { get; set; }

        public List<OrderDetailDto> OrderDetails { get; set; }
    }
}
