using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class MasterSocialMedium
    {
        public int MasterSocialMediumId { get; set; }
        [DisplayName("Media Name")]
        [Required(ErrorMessage = "This field is required")]
        public string MasterSocialMediaName { get; set; }
        [DisplayName("Media LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string MasterSocialMediaLinkUrl { get; set; }
        [DisplayName("Media IconUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string MasterSocialMediaIconUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
