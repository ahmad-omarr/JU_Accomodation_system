using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    public class VM_SystemSetting
    {
        public int SystemSettingId { get; set; }
        [DisplayName("LogoNav")]
        [Required(ErrorMessage = "This field is required")]

        public string SystemSettingLogoNav { get; set; }
        [DisplayName("LogoFooter")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingLogoFooter { get; set; }
        [DisplayName("Title Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingTitleDorm { get; set; }
        [DisplayName("Brief Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingBriefDorm { get; set; }
        [DisplayName("Brief Footer")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingBriefFooter { get; set; }
        [DisplayName("Zahraa Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingZahraaDorm { get; set; }
        [DisplayName("Andalus Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingAndalusDorm { get; set; }
        [DisplayName("Jerash Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingJerashDorm { get; set; }
        [DisplayName("Ammon Dorm")]
        [Required(ErrorMessage = "This field is required")]
        public string SystemSettingAmmonDorm { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_LogoNav { get; set; }
        public IFormFile File_LogoFooter { get; set; }



    }
}
