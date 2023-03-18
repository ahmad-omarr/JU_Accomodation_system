using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    public class MVAccounts 
    {

        public string id { get; set; }
        [Required]

        public string email { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string user_image { get; set; }
        public IFormFile File { get; set; }
        public string PassWord { get; set; }
        //public List<UserManager<ApplicationUser>> users { get; set; }

    }
}
