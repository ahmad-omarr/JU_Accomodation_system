using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    

    public class VM_MasterDorm
    {
        public int MasterDormId { get; set; }
        [DisplayName("Dorm Name")]
        [Required(ErrorMessage = "Please Enter Name Of Dorm")]
        public string MasterDormName { get; set; }
        [DisplayName("Dorm Brief")]
        [Required(ErrorMessage = "Please Enter Brief Of Dorm")]
        public string MasterDormBrief { get; set; }
        [DisplayName("Dorm LinkUrl")]
        [Required(ErrorMessage = "Please Enter LinkUrl Of Dorm")]
        public string MasterDormLinkUrl { get; set; }
        [DisplayName("Dorm LinkMap")]
        [Required(ErrorMessage = "Please Enter LinkMap Of Dorm")]
        public string MasterDormLinkMap { get; set; }
        [DisplayName("Dorm Image")]
        [Required(ErrorMessage = "Please Enter Image Of Dorm")]
        public string MasterDormImage { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File { get; set; }

    }
}
