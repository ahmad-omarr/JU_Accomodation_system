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
    public class VM_TransInternationalDormTripleRoom
    {
        public int TransInternationalDormTripleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Jarash Room Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJarashDormTripleRoomTitle { get; set; }
        [DisplayName("Jarash Room Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormTripleRoomBrief { get; set; }
        [DisplayName("Jarash Room Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormTripleRoomImage { get; set; }
        [DisplayName("Jarash Room LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransJerashDormTripleRoomLinkUrl { get; set; }
        [DisplayName("Ammon Room Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormTripleRoomTitle { get; set; }
        [DisplayName("Ammon Room Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormTripleRoomBrief { get; set; }
        [DisplayName("Ammon Room Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormTripleRoomImage { get; set; }
        [DisplayName("Ammon Room LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAmmonDormTripleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_Jerash { get; set; }

        public IFormFile  File_Ammon  { get; set; }

        public List<MasterDorm> ListMasterDorm { get; set; }
        public  MasterDorm MasterDorm { get; set; }

    }
}
