namespace Bakeryshop.Framework
{
    public class ErrorReource
    {
        public const string Required = "مقدار [{0}] را وارد کنید";
        public const string MaxLength = "مقدار [{0}] نباید بیشتر از [{1}] کاراکتر باشد";
        public const string MinLength = "مقدار [{0}] نباید کمتر از [{1}] کاراکتر باشد";
        public const string FixLength = "مقدار [{0}] باید [{1}] کاراکتر باشد";
        public const string Range = "مقدار [{0}] بایستی در بازه مقادیر [{1}] تا [{2}] باشد";
        public const string RangeMinimum = "مقدار [{0}] بایستی کمتر از [{1}] نباشد";
        public const string Invalid = "مقدار [{0}] نامعتبر می باشد";
        public const string EmailAddress = "مقدار [{0}] در ساختار پست الکترونیکی نمی باشد";
        public const string AllowedExtensions = "فایل انتخابی [{0}] بایستی در یکی از فرمتهای مجاز [{1}] باشد";
        public const string MaxFileSize = "حجم فایل انتخابی [{0}] بیش از مقدار مجاز [{1}] بایت می باشد";
        public const string RegularExpressionTime = "مقدار [{0}] در ساختار زمان نمی باشد";
        public const string RegularExpressionDate = "مقدار [{0}] در ساختار تاریخ نمی باشد";

        public const string InvalidFile = "فایل درخواستی نامعتبر است";
        public const string FileNotFound = "فایل مورد نظر یافت نشد";

        public const string Unauthorized = "برای استفاده از سیستم وارد شوید و یا ثبت نام کنید";
        public const string Forbidden = "شما مجوز دسترسی به این بخش از اطلاعات یا عملیات را ندارید";

        public const string UserLockedOut = "حساب کاربری شما به دلایل امنیتی قفل شده است";
        public const string UserDeactive = "حساب کاربری شما غیرفعال شده است، به منظور فعالسازی با مدیر سیستم تماس بگیرید";
        public const string UnRegisterUser = "اطلاعات کاربری شما ثبت نشده است، برای ورود به سیستم ثبت نام کنید";
        public const string UserAlreadyActivated = "اطلاعات کاربری قبلا فعال شده است، از بخش ورود یا بازیابی کلمه عبور اقدام کنید";
        public const string InvalidPassword = "کلمه عبور شما نادرست است، در صورت عدم یادآوری گزینه فراموشی کلمه عبور را انتخاب کنید";
        public const string InvalidUserOrPassword = "نام کاربری یا رمز عبور شما نادرست می باشد";
        public const string InvalidUser = "اطلاعات کاربری نادرست می باشد";
        public const string InvalidUserOrPhoneNumber = "نام کاربری یا شماره همراه شما نادرست می باشد";
        public const string InvalidEmployee = "اطلاعات پرسنلی وارد شده نادرست یا ثبت نشده می باشد";
        public const string InvalidToken = "ارتباط کاربری شما منقضی شده است لطفا مجددا احراز هویت فرمایید ";
        public const string InvalidActivate = "کد فعالسازی نادرست می باشد، کد فعالسازی دیگری درخواست کنید";
        public const string InvalidPassValue = "مقدار وارد شده برای کلمه عبور مناسب نمی باشد";
        public const string InvalidPhoneNumber = "مقدار تلفن همراه تائید نشده است برای تائید شماره از بخش ثبت نام وارد شوید";

        public const string DuplicateAgent = "تحویل گیرنده موجود است";


    }
}
