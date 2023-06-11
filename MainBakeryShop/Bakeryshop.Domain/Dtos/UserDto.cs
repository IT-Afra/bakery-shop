
using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class UserDto
    {
        [Display(Name = "شناسه")]
        public long Id { get; set; }

        [Display(Name = "عنوان")]
        [MaxLength(150, ErrorMessage = ErrorReource.MaxLength)]
        public string? Title { get; set; }

        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Name { get; set; }

        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Family { get; set; }

        [Display(Name = "جنسیت")]
        public bool? IsMale { get; set; }

        [Display(Name = "تاریخ تولد")]
        [MaxLength(10, ErrorMessage = ErrorReource.MaxLength)]
        public string? BirthDate { get; set; }

        [Display(Name = "تایید اطلاعات")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool InfoConfirmed { get; set; }

        [Display(Name = "شماره تلفن")]
        [MaxLength(15, ErrorMessage = ErrorReource.MaxLength)]
        [Required(ErrorMessage = ErrorReource.Required)]
        public string PhoneNumber { get; set; } = null!;

        [Display(Name = "تایید شماره تلفن")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool PhoneNumberConfirmed { get; set; }

        [Display(Name = "ایمیل")]
        [MaxLength(150, ErrorMessage = ErrorReource.MaxLength)]
        public string? Email { get; set; }

        [Display(Name = "تایید ایمیل")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool EmailConfirmed { get; set; }

        [Display(Name = "رمزعبور")]
        [MaxLength(256, ErrorMessage = ErrorReource.MaxLength)]
        public string? Password { get; set; }

        [Display(Name = "قفل حساب کاربری")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool LockoutEnabled { get; set; }

        [Display(Name = "پایان قفل حساب کاربری")]
        public DateTime? LockoutEnd { get; set; }

        [Display(Name = "شمارش دسترسی ناموفق")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int AccessFailedCount { get; set; }

        [Display(Name = "شمارش نوتیف  ")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int NotificationCount { get; set; }

        [Display(Name = "شمارش پیام")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int MessageCount { get; set; }

        [Display(Name = "شناسه یکتای سراسری عکس ")]
        [MaxLength(50, ErrorMessage = ErrorReource.MaxLength)]
        public string? PhotoGuid { get; set; }

        [Display(Name = "مسدویت پیام")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool IsMessageBlocked { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool IsActive { get; set; }
    }
}
