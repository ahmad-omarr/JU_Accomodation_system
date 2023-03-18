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
    public class VM_TransInnerDormDoubleRoom
    {
        public int TransInnerDormDoubleRoomId { get; set; }
        public int MasterDormId { get; set; }
       
        [DisplayName("Zahraa Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormDoubleRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormDoubleRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormDoubleRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormDoubleRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormDoubleRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormDoubleRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormDoubleRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormDoubleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_Zahraa { get; set; }
        public IFormFile File_Andalus { get; set; }


        public List<MasterDorm> ListMasterDorm { get; set; }
        public virtual MasterDorm MasterDorm { get; set; } 
    }
}
