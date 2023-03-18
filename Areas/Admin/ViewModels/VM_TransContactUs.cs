using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace SystemWebDorms.Areas.Admin.ViewModels
{
    public class VM_TransContactUs
    {
        public int TransContactUsId { get; set; }
        [DisplayName("ContactUs Title")]
        public string TransContactUsTitle { get; set; }
        [DisplayName("ContactUs FirstName")]
        public string TransContactUsFirstName { get; set; }
        [DisplayName("ContactUs LastName")]
        public string TransContactUsLastName { get; set; }
        [DisplayName("ContactUs StudentNumber")]
        public string TransContactUsStudentNumber { get; set; }
        [DisplayName("ContactUs Discrption")]
        public string TransContactUsDiscrption { get; set; }
        [DisplayName("ContactUs Date")]

        public DateTime? TransContactUsDate { get; set; }
        [DisplayName("ContactUs UrlImage")]
        public string TransContactUrlImage { get; set; }
        [DisplayName("ContactUs LinkUrl")]

        public string TransContactLinkUrl { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile File { get; set; }

    }
}
