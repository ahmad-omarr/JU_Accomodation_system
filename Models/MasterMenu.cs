using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace SystemWebDorms.Models
{
    public partial class MasterMenu
    {
        public int MasterMenuId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Menu Name")]
        //[Required(ErrorMessage = "This field is required")]
        public string MasterMenuName { get; set; }
        [DisplayName("Menu LinkUrl")]
        //[Required(ErrorMessage = "This field is required")]
        public string MasterMenuLinkUrl { get; set; }
        [DisplayName("DropMenu Name")]
        //[Required(ErrorMessage = "This field is required")]
        public string MasterMenuDropMenu { get; set; }
        [DisplayName("Menu DropLink")]
        //[Required(ErrorMessage = "This field is required")]
        public string MasterMenuDropMenuLink { get; set; }
        public List<MasterDorm> ListMasterDorm { get; set; }
        public virtual MasterDorm MasterDorm { get; set; }

        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
