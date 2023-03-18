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
    public class VM_TransInnerDormNight
    {
        public int TransInnerDormNightId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Zahraa Title")]
        [Required(ErrorMessage = "This field is required")]

        public string TransZahraaDormNightRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]
        [Required(ErrorMessage = "This field is required")]

        public string TransZahraaDormNightRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormNightRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormNightRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormNightRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormNightRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormNightRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormNightRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_Zahraa { get; set; }
        public IFormFile File_Andalus { get; set; }
        public List<MasterDorm> ListMasterDorm { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }

    }
}
