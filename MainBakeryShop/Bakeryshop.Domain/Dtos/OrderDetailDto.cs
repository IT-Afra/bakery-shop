using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class OrderDetailDto
    {
        [Display(Name = "شناسه")]
        public long? Id { get; set; }

        [Display(Name = "شناسه نوع نان")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public long? TypeBreadId { get; set; }

        [Display(Name = "نام نوع نان")]
        // Add this new field to database and define MaxLenght here!
        public string? TypeBreadName { get; set; }

        [Display(Name = "قیمت")]
        public decimal? Price { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int? Amount { get; set; }

        [Display(Name = "تعداد سفارش")]
        public int? DeliveryAmount { get; set; }
    }
}
