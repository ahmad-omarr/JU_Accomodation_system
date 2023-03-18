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
    public class VM_TransInnerDormTripleRoom
    {
        public int TransInnerDormTripleRoomId { get; set; }
        public int MasterDormId { get; set; }
        [DisplayName("Zahraa Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormTripleRoomTitle { get; set; }
        [DisplayName("Zahraa Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormTripleRoomBrief { get; set; }
        [DisplayName("Zahraa Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormTripleRoomImage { get; set; }
        [DisplayName("Zahraa LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransZahraaDormTripleRoomLinkUrl { get; set; }
        [DisplayName("Andalus Title")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormTripleRoomTitle { get; set; }
        [DisplayName("Andalus Brief")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormTripleRoomBrief { get; set; }
        [DisplayName("Andalus Image")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormTripleRoomImage { get; set; }
        [DisplayName("Andalus LinkUrl")]
        [Required(ErrorMessage = "This field is required")]
        public string TransAndalusDormTripleRoomLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File_Zahraa { get; set; }
        public IFormFile File_Andalus { get; set; }

        public List<MasterDorm> ListMasterDorm { get; set; }

        public virtual MasterDorm MasterDorm { get; set; }
    }
}
