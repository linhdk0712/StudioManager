using System;
using System.ComponentModel.DataAnnotations;

namespace StudioApplication.Areas.SysAdmin.Models
{
    public class NewStudioViewModel
    {
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(50)]
        [Display(Name = "Studio Code")]
        public string StudioCode { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(250)]
        [Display(Name = "Studio Name")]
        public string StudioName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(250)]
        [Display(Name = "Skype")]
        public string SkypeName { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(150)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(500)]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(500)]
        [Display(Name = "Logo")]
        public string Logo { get; set; }

        [Display(Name = "Status")]
        public bool Status { get; set; }

        public DateTime CreateDate { get; set; }

        public string CreateBy { get; set; }
    }
}