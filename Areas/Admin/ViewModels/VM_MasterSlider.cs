using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    public class VM_MasterSlider
    {
        public int MasterSliderId { get; set; }
        [DisplayName("Slider ImageUrl ")]
        [Required(ErrorMessage = "This field is required")]    
        public string MasterSliderImageUrl { get; set; }
        [DisplayName("Slider Title")]
        [Required(ErrorMessage = "This field is required")] 
        public string MasterSliderTitle { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }

        public IFormFile File { get; set; }

        //public List<MasterDorm> ListMasterDorm { get; set; }
        //public virtual MasterDorm MasterDorm { get; set; }
    }
}
