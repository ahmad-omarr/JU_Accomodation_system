using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable

namespace SystemWebDorms.Models
{
    
    public partial class MasterDorm
    {
        //public MasterDorm()
        //{
        //    TransInnerDormDoubleRooms = new HashSet<TransInnerDormDoubleRoom>();
        //    TransInnerDormNights = new HashSet<TransInnerDormNight>();
        //    TransInnerDormTripleRooms = new HashSet<TransInnerDormTripleRoom>();
        //    TransInternationalDormDoubleRoomSisters = new HashSet<TransInternationalDormDoubleRoomSister>();
        //    TransInternationalDormDoubleRooms = new HashSet<TransInternationalDormDoubleRoom>();
        //    TransInternationalDormNightRooms = new HashSet<TransInternationalDormNightRoom>();
        //    TransInternationalDormSingleRooms = new HashSet<TransInternationalDormSingleRoom>();
        //    TransInternationalDormTripleRooms = new HashSet<TransInternationalDormTripleRoom>();
        //}

        public int MasterDormId { get; set; }
        [DisplayName("Dorm Name")]

        public string MasterDormName { get; set; }
        [DisplayName("Brief")]

        public string MasterDormBrief { get; set; }
        [DisplayName("LinkUrl")]

        public string MasterDormLinkUrl { get; set; }
        [DisplayName("LinkMap")]

        public string MasterDormLinkMap { get; set; }
        [DisplayName("Image")]

        public string MasterDormImage { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }


        //public virtual ICollection<TransInnerDormDoubleRoom> TransInnerDormDoubleRooms { get; set; }
        //public virtual ICollection<TransInnerDormNight> TransInnerDormNights { get; set; }
        //public virtual ICollection<TransInnerDormTripleRoom> TransInnerDormTripleRooms { get; set; }
        //public virtual ICollection<TransInternationalDormDoubleRoomSister> TransInternationalDormDoubleRoomSisters { get; set; }
        //public virtual ICollection<TransInternationalDormDoubleRoom> TransInternationalDormDoubleRooms { get; set; }
        //public virtual ICollection<TransInternationalDormNightRoom> TransInternationalDormNightRooms { get; set; }
        //public virtual ICollection<TransInternationalDormSingleRoom> TransInternationalDormSingleRooms { get; set; }
        //public virtual ICollection<TransInternationalDormTripleRoom> TransInternationalDormTripleRooms { get; set; }
    }
}
