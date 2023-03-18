using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class SystemSetting
    {
        public int SystemSettingId { get; set; }
        [DisplayName("LogoNav")]
        public string SystemSettingLogoNav { get; set; }
        [DisplayName("LogoFooter")]
        public string SystemSettingLogoFooter { get; set; }
        [DisplayName("Title Dorm")]
        public string SystemSettingTitleDorm { get; set; }
        [DisplayName("Brief Dorm")]
        public string SystemSettingBriefDorm { get; set; }
        [DisplayName("Brief Footer")]
        public string SystemSettingBriefFooter { get; set; }
        [DisplayName("Zahraa Dorm")]
        public string SystemSettingZahraaDorm { get; set; }
        [DisplayName("Andalus Dorm")]
        public string SystemSettingAndalusDorm { get; set; }
        [DisplayName("Jerash Dorm")]
        public string SystemSettingJerashDorm { get; set; }
        [DisplayName("Ammon Dorm")]
        public string SystemSettingAmmonDorm { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
