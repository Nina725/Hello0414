using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410816897.ViewModols
{
    public class SignUpData
    {
        [Display(Name = "姓名")]
        [Required(ErrorMessage = "請輸入姓名")]
        [MinLength(5, ErrorMessage = "請輸入至少5個字")]
        [MaxLength(10, ErrorMessage = "請輸入少於10個字")]
        public string Name { get; set; }

        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        [EmailAddress(ErrorMessage = "請輸入正確的Email")]

        public string Account { get; set; }

        [Display(Name = "帳號")]
        [Required(ErrorMessage = "請輸入帳號")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入5~10個字")]

        public string Password { get; set; }


        public string Msssage { get; set; }

    }
}