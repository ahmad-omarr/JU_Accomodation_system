using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class MasterSlider
    {
        public int MasterSliderId { get; set; }
        [DisplayName("Slider ImageUrl ")]
        public string MasterSliderImageUrl { get; set; }
        [DisplayName("Slider Title ")]
        public string MasterSliderTitle { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
