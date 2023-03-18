using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using SystemWebDorms.Models;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    public class VM_TransInternationalDormSingleRoom
    {
        public int TransInternationalDormSingleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJarashDormSingleRoomTitle { get; set; }
        [DisplayName("Jarash Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormSingleRoomBrief { get; set; }
        [DisplayName("Jarash Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormSingleRoomImage { get; set; }
        [DisplayName("Jarash LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormSingleRoomLinkUrl { get; set; }
        [DisplayName("Ammon Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormSingleRoomTitle { get; set; }
        [DisplayName("Ammon Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormSingleRoomBrief { get; set; }
        [DisplayName("Ammon Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormSingleRoomImage { get; set; }
        [DisplayName("Ammon LinkUrl")]
        public string TransAmmonDormSingleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_Jerash { get; set; }
        public IFormFile File_Ammon { get; set; }

        public List<MasterDorm> ListMasterDorm { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
